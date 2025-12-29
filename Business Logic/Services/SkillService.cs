using AutoMapper;
using BusinessLogic.DTOs.Skills;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class SkillService : ISkillService
    {
        private readonly IGeneralRepository<Skill> _repo;
        private readonly IMapper _mapper;

        public SkillService(IGeneralRepository<Skill> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET /api/skills
        public async Task<IEnumerable<GetSkillDTO>> GetAllAsync()
        {
            var skills = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<GetSkillDTO>>(skills);
        }

        // GET /api/skills/{id}
        public async Task<GetSkillDTO?> GetByIdAsync(int id)
        {
            var skill = await _repo.GetByID(id);
            return skill == null ? null : _mapper.Map<GetSkillDTO>(skill);
        }

        // POST
        public async Task AddAsync(AddSkillDTO dto, string createdBy)
        {
            var skill = _mapper.Map<Skill>(dto);
            skill.CreatedBy = createdBy;
            skill.CreatedAt = DateTime.UtcNow;

            await _repo.Add(skill);
        }

        // PUT
        public async Task UpdateAsync(int id, UpdateSkillDTO dto, string updatedBy)
        {
            var skill = await _repo.GetByIDWithTracking(id);
            if (skill == null)
                throw new Exception("Skill not found");

            _mapper.Map(dto, skill);
            skill.UpdatedBy = updatedBy;
            skill.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(skill);
        }

        // DELETE (Soft Delete)
        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(id);
        }
    }
}
