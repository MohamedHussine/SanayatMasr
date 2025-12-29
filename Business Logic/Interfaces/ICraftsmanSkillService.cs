

namespace BusinessLogic.Interfaces
{
    public interface ICraftsmanSkillService
    {
        Task<IEnumerable<CraftsmanSkillResponseDTO>> GetByCraftsmanAsync(int craftsmanId);
        Task AddAsync(int craftsmanId, CreateCraftsmanSkillDTO dto);
        Task UpdateAsync(int craftsmanId, int skillId, UpdateCraftsmanSkillDTO dto);
        Task DeleteAsync(int craftsmanId, int skillId);
    }
}
