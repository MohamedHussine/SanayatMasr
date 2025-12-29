using BusinessLogic.DTOs.Governorates;

namespace BusinessLogic.Interfaces
{
    public interface IGovernorateService
    {
        Task<IEnumerable<GovernorateListDTO>> GetAllAsync();
        Task<GovernorateDetailsDTO?> GetByIdAsync(int id);
        Task AddAsync(AddGovernorateDTO dto);
        Task UpdateAsync(int id, UpdateGovernorateDTO dto);
        Task DeleteAsync(int id);
    }
}
