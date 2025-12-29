using AutoMapper;
using BusinessLogic.DTOs.Users;

using DataAccess.Interfaces;

using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IGeneralRepository<User> _repo;
        private readonly IMapper _mapper;

        public UserService(
            IGeneralRepository<User> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetUserDTO>> GetAllAsync()
        {
            var users = await _repo.GetAll()
                .Where(x => !x.IsDeleted)
                .ToListAsync();

            return _mapper.Map<IEnumerable<GetUserDTO>>(users);
        }

        public async Task<GetUserDTO?> GetByIdAsync(int id)
        {
            var user = await _repo.GetByID(id);
            if (user == null || user.IsDeleted)
                return null;

            return _mapper.Map<GetUserDTO>(user);
        }

        public async Task<bool> UpdateAsync(int id, UpdateUserDTO dto, string adminId)
        {
            var user = await _repo.GetByIDWithTracking(id);
            if (user == null || user.IsDeleted)
                return false;

            _mapper.Map(dto, user);
            user.UpdatedBy = adminId;
            user.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(user);
            return true;
        }

        public async Task<bool> DeleteAsync(int id, string adminId)
        {
            var user = await _repo.GetByIDWithTracking(id);
            if (user == null || user.IsDeleted)
                return false;

            user.IsDeleted = true;
            user.IsActive = false;
            user.UpdatedBy = adminId;
            user.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(user);
            return true;
        }

        public async Task<bool> UpdateProfileImageAsync(int userId, string imageUrl)
        {
            var user = await _repo.GetByIDWithTracking(userId);
            if (user == null || user.IsDeleted)
                return false;

            user.ProfileImage = imageUrl;
            user.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(user);
            return true;
        }
    }
}
