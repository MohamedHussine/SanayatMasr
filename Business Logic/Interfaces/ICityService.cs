using BusinessLogic.DTOs.City;

namespace BusinessLogic.Interfaces
{
    // Interface بين Controller و Service
    public interface ICityService
    {
        Task<IEnumerable<GetAllCityDTO>> GetAllAsync();
        Task<GetCityByIdDTO?> GetByIdAsync(int id);
        Task<IEnumerable<GetAllCityDTO>> GetByGovernorateAsync(int governorateId);

        Task AddAsync(AddCityDTO dto);
        Task UpdateAsync(int id, UpdateCityDTO dto);
        Task DeleteAsync(int id);
    }
}
