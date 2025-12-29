
using BusinessLogic.DTOs.Craftsmen;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

public class CraftsmanCityService : ICraftsmanCityService
{
    private readonly IGeneralRepository<CraftsmanCity> _repo;

    public CraftsmanCityService(IGeneralRepository<CraftsmanCity> repo)
    {
        _repo = repo;
    }

    // ================= GET =================
    public async Task<IEnumerable<CraftsmanCityResponseDTO>> GetByCraftsmanAsync(int craftsmanId)
    {
        return await _repo.GetAll()
            .Include(x => x.City)
            .Where(x => x.CraftsmanId == craftsmanId && !x.IsDeleted)
            .Select(x => new CraftsmanCityResponseDTO
            {
                CityId = x.CityId,
                CityName = x.City!.Name,
                IsPrimary = x.IsPrimary
            })
            .ToListAsync();
    }

    // ================= POST =================
    public async Task AddAsync(int craftsmanId, CreateCraftsmanCityDTO dto)
    {
        var exists = await _repo.GetAll()
            .AnyAsync(x =>
                x.CraftsmanId == craftsmanId &&
                x.CityId == dto.CityId &&
                !x.IsDeleted);

        if (exists)
            throw new Exception("City already added");

        bool hasPrimary = await _repo.GetAll()
            .AnyAsync(x => x.CraftsmanId == craftsmanId && x.IsPrimary && !x.IsDeleted);

        var entity = new CraftsmanCity
        {
            CraftsmanId = craftsmanId,
            CityId = dto.CityId,
            IsPrimary = !hasPrimary, // ✅ أول مدينة تبقى Primary
            CreatedAt = DateTime.UtcNow
        };

        _repo.Add(entity);
    }

    // ================= SET PRIMARY =================
    public async Task SetPrimaryAsync(int craftsmanId, int cityId)
    {
        var cities = await _repo.GetAll()
            .Where(x => x.CraftsmanId == craftsmanId && !x.IsDeleted)
            .ToListAsync();

        if (!cities.Any())
            throw new Exception("No cities found");

        foreach (var city in cities)
            city.IsPrimary = false;

        var target = cities.FirstOrDefault(x => x.CityId == cityId);
        if (target == null)
            throw new Exception("City not found");

        target.IsPrimary = true;
        target.UpdatedAt = DateTime.UtcNow;
    }

    // ================= DELETE =================
    public async Task DeleteAsync(int craftsmanId, int cityId)
    {
        var entity = await _repo.GetAll()
            .FirstOrDefaultAsync(x =>
                x.CraftsmanId == craftsmanId &&
                x.CityId == cityId &&
                !x.IsDeleted);

        if (entity == null)
            throw new Exception("City not found");

        entity.IsDeleted = true;
        entity.IsPrimary = false;
        entity.UpdatedAt = DateTime.UtcNow;
    }
}
