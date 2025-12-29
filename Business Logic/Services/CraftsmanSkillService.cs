

using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class CraftsmanSkillService : ICraftsmanSkillService
    {
        private readonly IGeneralRepository<CraftsmanSkill> _repo;

        public CraftsmanSkillService(IGeneralRepository<CraftsmanSkill> repo)
        {
            _repo = repo;
        }

        // ================= GET =================
        public async Task<IEnumerable<CraftsmanSkillResponseDTO>> GetByCraftsmanAsync(int craftsmanId)
        {
            return await _repo.GetAll()
                .Include(x => x.Skill)
                .Where(x => x.CraftsmanId == craftsmanId && !x.IsDeleted)
                .Select(x => new CraftsmanSkillResponseDTO
                {
                    SkillId = x.SkillId,
                    SkillName = x.Skill!.Name,
                    ProficiencyLevel = x.ProficiencyLevel // ✅ Enum مباشر
                })
                .ToListAsync();
        }

        // ================= POST =================
        public async Task AddAsync(int craftsmanId, CreateCraftsmanSkillDTO dto)
        {
            var exists = await _repo.GetAll()
                .AnyAsync(x =>
                    x.CraftsmanId == craftsmanId &&
                    x.SkillId == dto.SkillId &&
                    !x.IsDeleted);

            if (exists)
                throw new Exception("Skill already added to this craftsman");

            var entity = new CraftsmanSkill
            {
                CraftsmanId = craftsmanId,
                SkillId = dto.SkillId,
                ProficiencyLevel = dto.ProficiencyLevel, // ✅ Enum
                CreatedAt = DateTime.UtcNow
            };

            _repo.Add(entity); 
        }

        // ================= PUT =================
        public async Task UpdateAsync(int craftsmanId, int skillId, UpdateCraftsmanSkillDTO dto)
        {
            var entity = await _repo.GetAll()
                .FirstOrDefaultAsync(x =>
                    x.CraftsmanId == craftsmanId &&
                    x.SkillId == skillId &&
                    !x.IsDeleted);

            if (entity == null)
                throw new Exception("Skill not found");

            entity.ProficiencyLevel = dto.ProficiencyLevel; // ✅ Enum
            entity.UpdatedAt = DateTime.UtcNow;
        }

        // ================= DELETE =================
        public async Task DeleteAsync(int craftsmanId, int skillId)
        {
            var entity = await _repo.GetAll()
                .FirstOrDefaultAsync(x =>
                    x.CraftsmanId == craftsmanId &&
                    x.SkillId == skillId &&
                    !x.IsDeleted);

            if (entity == null)
                throw new Exception("Skill not found");

            entity.IsDeleted = true;
            entity.UpdatedAt = DateTime.UtcNow;
        }
    }
}
