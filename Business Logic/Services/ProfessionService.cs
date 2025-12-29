using AutoMapper;
using BusinessLogic.DTOs.Professions;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    // Business Logic الخاص بالمهن
    public class ProfessionService : IProfessionService
    {
        private readonly IGeneralRepository<Profession> _repo;
        private readonly IMapper _mapper;

        public ProfessionService(
            IGeneralRepository<Profession> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // ================= GET ALL =================
        public async Task<IEnumerable<ProfessionResponseDTO>> GetAllAsync()
        {
            var list = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<ProfessionResponseDTO>>(list);
        }

        // ================= GET BY ID =================
        public async Task<ProfessionResponseDTO?> GetByIdAsync(int id)
        {
            var entity = await _repo.GetByID(id);
            if (entity == null) return null;

            return _mapper.Map<ProfessionResponseDTO>(entity);
        }

        // ================= CREATE =================
        public async Task CreateAsync(CreateProfessionDTO dto)
        {
            var entity = _mapper.Map<Profession>(dto);
            entity.CreatedAt = DateTime.UtcNow;

            await _repo.Add(entity);
        }

        // ================= UPDATE (✔ FIXED) =================
        public async Task UpdateAsync(int id, UpdateProfessionDTO dto)
        {
            // لازم Tracking
            var entity = await _repo.GetByIDWithTracking(id);
            if (entity == null)
                throw new Exception("Profession not found");

            // Map التعديلات
            _mapper.Map(dto, entity);

            entity.UpdatedAt = DateTime.UtcNow;

            // 🔥 ده الحل اللي كان ناقص
            await _repo.Update(entity);
        }

        // ================= DELETE =================
        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(id);
        }
    }
}
