
using BusinessLogic.DTOs.Skills;

namespace BusinessLogic.Interfaces
{
    public interface ISkillService
    {
        Task<IEnumerable<GetSkillDTO>> GetAllAsync();
        Task<GetSkillDTO?> GetByIdAsync(int id);
        Task AddAsync(AddSkillDTO dto, string createdBy);
        Task UpdateAsync(int id, UpdateSkillDTO dto, string updatedBy);
        Task DeleteAsync(int id);
    }
}
