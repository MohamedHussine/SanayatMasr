using AutoMapper;
using BusinessLogic.DTOs.Auth;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.Helpers._ٌResponse;

namespace BusinessLogic.Services
{
    public class AuthService : IAuthService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher _hasher;
        private readonly ITokenService _tokenService;

        public AuthService(
            Context context,
            IMapper mapper,
            IPasswordHasher hasher,
            ITokenService tokenService)
        {
            _context = context;
            _mapper = mapper;
            _hasher = hasher;
            _tokenService = tokenService;
        }

        // =========================
        // REGISTER
        // =========================
        public async Task<ServiceResult<AuthResponseDTO>> RegisterAsync(RegisterRequestDTO dto)
        {
            bool emailExists = await _context.Users
                .AnyAsync(x => x.Email == dto.Email && !x.IsDeleted);

            if (emailExists)
                return ServiceResult<AuthResponseDto>.Fail("Email already exists");

            var user = _mapper.Map<User>(dto);
            user.PasswordHash = _hasher.Hash(dto.Password);
            user.IsActive = true;
            user.CreatedAt = DateTime.UtcNow;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // 👇 إضافة Craftsman تلقائي لو الدور Craftsman
            if (user.Role == "Craftsman")
            {
                var craftsman = new Craftsman
                {
                    UserId = user.Id,
                    ProfessionId = 1, // لازم موجود في DB
                    Bio = string.Empty,
                    ExperienceYears = 0,
                    MinPrice = 0,
                    MaxPrice = 0,
                    IsVerified = false,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                _context.Craftsmens.Add(craftsman);
                await _context.SaveChangesAsync();
            }

            var authResponse = await _tokenService.GenerateAsync(user);

            return ServiceResult<AuthResponseDto>
                .Ok(authResponse, "Registered successfully");
        }

        // =========================
        // LOGIN
        // =========================
        public async Task<ServiceResult<AuthResponseDTO>> LoginAsync(LoginRequestDTO dto)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(x => x.Email == dto.Email && !x.IsDeleted);

            if (user == null)
                return ServiceResult<AuthResponseDTO>.Fail("Invalid email or password");

            if (!_hasher.Verify(dto.Password, user.PasswordHash))
                return ServiceResult<AuthResponseDTO>.Fail("Invalid email or password");

            if (!user.IsActive)
                return ServiceResult<AuthResponseDTO>.Fail("User is disabled");

            var authResponse = await _tokenService.GenerateAsync(user);

            return ServiceResult<AuthResponseDTO>
                .Ok(authResponse, "Login successful");
        }

        // =========================
        // REFRESH TOKEN ✅ (اللي كانت ناقصة)
        // =========================
        public async Task<ServiceResult<AuthResponseDTO>> RefreshTokenAsync(string refreshToken)
        {
            var authResponse = await _tokenService.RefreshAsync(refreshToken);

            if (authResponse == null)
                return ServiceResult<AuthResponseDTO>
                    .Fail("Invalid or expired refresh token");

            return ServiceResult<AuthResponseDTO>
                .Ok(authResponse, "Token refreshed successfully");
        }

        // =========================
        // LOGOUT
        // =========================
        public async Task<ServiceResult<bool>> LogoutAsync(int userId)
        {
            var tokens = await _context.RefreshTokens
                .Where(x => x.UserId == userId && !x.IsRevoked)
                .ToListAsync();

            if (!tokens.Any())
                return ServiceResult<bool>.Fail("No active sessions found");

            tokens.ForEach(x => x.IsRevoked = true);
            await _context.SaveChangesAsync();

            return ServiceResult<bool>.Ok(true, "Logged out successfully");
        }
    }
}
