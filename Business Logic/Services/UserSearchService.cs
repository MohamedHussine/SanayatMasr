using AutoMapper;
using BusinessLogic.DTOs.Users;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class UserSearchService : IUserSearchService
    {
        private readonly IGeneralRepository<User> _repo;
        private readonly IMapper _mapper;

        public UserSearchService(
            IGeneralRepository<User> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserSearchResultDTO>> SearchAsync(
            string? name,
            string? email,
            string? phone,
            string? role,
            int? governorateId,
            int? cityId)
        {
            var query = _repo.GetAll()
                .Include(x => x.Governorate)
                .Include(x => x.City)
                .Where(x => !x.IsDeleted);

            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(x => x.FullName.Contains(name));

            if (!string.IsNullOrWhiteSpace(email))
                query = query.Where(x => x.Email.Contains(email));

            if (!string.IsNullOrWhiteSpace(phone))
                query = query.Where(x => x.Phone!.Contains(phone));

            if (!string.IsNullOrWhiteSpace(role))
                query = query.Where(x => x.Role == role);

            if (governorateId.HasValue)
                query = query.Where(x => x.GovernorateId == governorateId);

            if (cityId.HasValue)
                query = query.Where(x => x.CityId == cityId);

            var users = await query.ToListAsync();

            return _mapper.Map<IEnumerable<UserSearchResultDTO>>(users);
        }
    }
}
