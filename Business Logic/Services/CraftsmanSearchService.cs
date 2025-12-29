using AutoMapper;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class CraftsmanSearchService : ICraftsmanSearchService
    {
        private readonly IGeneralRepository<Craftsman> _repo;
        private readonly IMapper _mapper;

        public CraftsmanSearchService(
            IGeneralRepository<Craftsman> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CraftsmanSearchResultDto>> SearchAsync(
            string? name,
            int? professionId,
            int? governorateId,
            int? cityId,
            decimal? minPrice,
            decimal? maxPrice,
            int? minExperience,
            bool? isVerified)
        {
            var query = _repo.GetAll()
                .Include(x => x.User)
                    .ThenInclude(u => u.Governorate)
                .Include(x => x.User)
                    .ThenInclude(u => u.City)
                .Include(x => x.Profession)
                .Include(x => x.GalleryImages)
                .Where(x => !x.IsDeleted);

            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(x =>
                    x.User != null &&
                    x.User.FullName.Contains(name));

            if (professionId.HasValue)
                query = query.Where(x => x.ProfessionId == professionId);

            if (governorateId.HasValue)
                query = query.Where(x =>
                    x.User != null &&
                    x.User.GovernorateId == governorateId);

            if (cityId.HasValue)
                query = query.Where(x =>
                    x.User != null &&
                    x.User.CityId == cityId);

            if (minPrice.HasValue)
                query = query.Where(x => x.MinPrice >= minPrice);

            if (maxPrice.HasValue)
                query = query.Where(x => x.MaxPrice <= maxPrice);

            if (minExperience.HasValue)
                query = query.Where(x => x.ExperienceYears >= minExperience);

            if (isVerified.HasValue)
                query = query.Where(x => x.IsVerified == isVerified);

            var data = await query.ToListAsync();
            return _mapper.Map<IEnumerable<CraftsmanSearchResultDto>>(data);
        }
    }
}
