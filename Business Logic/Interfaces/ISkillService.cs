
using BusinessLogic.DTOs.Skills;

namespace BusinessLogic.Interface
{
    public interface ISkillService
    {
        Task<IEnumerable<GetSkillDto>> GetAllAsync();
        Task<GetSkillDto?> GetByIdAsync(int id);
        Task AddAsync(AddSkillDto dto, string createdBy);
        Task UpdateAsync(int id, UpdateSkillDto dto, string updatedBy);
        Task DeleteAsync(int id);
    }
}
