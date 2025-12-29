using AutoMapper;
using BusinessLogic.DTOs.City;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    // تنفيذ منطق المدن
    public class CityService : ICityService
    {
        private readonly IGeneralRepository<City> _repo;
        private readonly IMapper _mapper;

        public CityService(IGeneralRepository<City> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET /api/cities
        public async Task<IEnumerable<GetAllCityDTO>> GetAllAsync()
        {
            var cities = await _repo.GetAll()
                .Include(x => x.Governorate)
                .ToListAsync();

            return _mapper.Map<IEnumerable<GetAllCityDTO>>(cities);
        }

        // GET /api/cities/{id}
        public async Task<GetCityByIdDTO?> GetByIdAsync(int id)
        {
            var city = await _repo.GetAll()
                .Include(x => x.Governorate)
                .FirstOrDefaultAsync(x => x.Id == id);

            return city == null ? null : _mapper.Map<GetCityByIdDTO>(city);
        }

        // GET /api/governorates/{govId}/cities
        public async Task<IEnumerable<GetAllCityDTO>> GetByGovernorateAsync(int governorateId)
        {
            var cities = await _repo.GetAll()
                .Include(x => x.Governorate)
                .Where(x => x.GovernorateId == governorateId)
                .ToListAsync();

            return _mapper.Map<IEnumerable<GetAllCityDTO>>(cities);
        }

        // POST
        public async Task AddAsync(AddCityDTO dto)
        {
            var city = _mapper.Map<City>(dto);
            await _repo.Add(city);
        }

        // PUT
        public async Task UpdateAsync(int id, UpdateCityDTO dto)
        {
            var city = await _repo.GetByIDWithTracking(id);
            if (city == null)
                throw new Exception("City not found");

            _mapper.Map(dto, city);
            city.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(city);
        }

        // DELETE (Soft)
        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(id);
        }
    }
}
