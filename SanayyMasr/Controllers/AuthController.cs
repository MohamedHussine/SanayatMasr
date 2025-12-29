using BusinessLogic.DTOs.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // =========================
        // REGISTER
        // Public
        // =========================
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterAsync(dto);

            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }

        // =========================
        // LOGIN
        // Public
        // =========================
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.LoginAsync(dto);

            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }

        // =========================
        // REFRESH TOKEN
        // Public
        // =========================
        [HttpPost("refresh-token")]
        [AllowAnonymous]
        public async Task<IActionResult> Refresh([FromBody] RefreshTokenRequestDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RefreshTokenAsync(dto.RefreshToken);

            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }

        // =========================
        // LOGOUT
        // Authorized user only
        // =========================
        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            // 👤 Get UserId from JWT
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim == null)
                return Unauthorized(new
                {
                    success = false,
                    message = "Invalid token"
                });

            int userId = int.Parse(userIdClaim.Value);

            var result = await _authService.LogoutAsync(userId);

            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }

        // =========================
        // ME (Current Logged-in User)
        // =========================
        [Authorize]
        [HttpGet("me")]
        public IActionResult Me()
        {
            // Standard claims
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            var emailClaim = User.FindFirst(ClaimTypes.Email);
            var roleClaim = User.FindFirst(ClaimTypes.Role);

            // Custom claims (added in TokenService)
            var fullNameClaim = User.FindFirst("fullName");
            var profileImageClaim = User.FindFirst("profileImage");

            if (userIdClaim == null)
            {
                return Unauthorized(new
                {
                    success = false,
                    message = "Invalid token"
                });
            }

            return Ok(new
            {
                success = true,
                data = new
                {
                    userId = int.Parse(userIdClaim.Value),
                    email = emailClaim?.Value,
                    role = roleClaim?.Value,
                    fullName = fullNameClaim?.Value,
                    profileImageUrl = profileImageClaim?.Value
                }
            });
        }
    }
}
