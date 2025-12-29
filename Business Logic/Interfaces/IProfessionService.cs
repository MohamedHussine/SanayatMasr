using BusinessLogic.DTOs.Professions;

namespace BusinessLogic.Interfaces
{
    // Contract خاص بـ Profession Service
    public interface IProfessionService
    {
        Task<IEnumerable<ProfessionResponseDTO>> GetAllAsync();
        Task<ProfessionResponseDTO?> GetByIdAsync(int id);

        Task CreateAsync(CreateProfessionDTO dto);
        Task UpdateAsync(int id, UpdateProfessionDTO dto);
        Task DeleteAsync(int id);
    }
}
