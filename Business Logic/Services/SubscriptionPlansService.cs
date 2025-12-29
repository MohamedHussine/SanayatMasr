using AutoMapper;
using BusinessLogic.DTOs.SubscriptionPlans;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace BusinessLogic.Services
{
    public class SubscriptionPlanService : ISubscriptionPlanService
    {
        private readonly IGeneralRepository<SubscriptionPlan> _repo;
        private readonly IMapper _mapper;

        public SubscriptionPlanService(
            IGeneralRepository<SubscriptionPlan> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET ALL
        public async Task<IEnumerable<GetSubscriptionPlanDTO>> GetAllAsync()
        {
            var plans = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<GetSubscriptionPlanDTO>>(plans);
        }

        // GET BY ID
        public async Task<GetSubscriptionPlanDTO?> GetByIdAsync(int id)
        {
            var plan = await _repo.GetByID(id);
            if (plan == null) return null;

            return _mapper.Map<GetSubscriptionPlanDTO>(plan);
        }

        // CREATE
        public async Task<int> CreateAsync(CreateSubscriptionPlanDTO dto, string createdBy)
        {
            var plan = _mapper.Map<SubscriptionPlan>(dto);

            plan.CreatedBy = createdBy;
            plan.IsActive = true;

            await _repo.Add(plan);
            return plan.Id;
        }

        // UPDATE
        public async Task<bool> UpdateAsync(int id, UpdateSubscriptionPlanDTO dto, string updatedBy)
        {
            var plan = await _repo.GetByIDWithTracking(id);
            if (plan == null) return false;

            _mapper.Map(dto, plan);
            plan.UpdatedBy = updatedBy;
            plan.UpdatedAt = DateTime.Now;

            await _repo.Update(plan);
            return true;
        }

        // DELETE (Soft Delete)
        public async Task<bool> DeleteAsync(int id, string deletedBy)
        {
            var plan = await _repo.GetByIDWithTracking(id);
            if (plan == null) return false;

            plan.IsDeleted = true;
            plan.UpdatedBy = deletedBy;
            plan.UpdatedAt = DateTime.Now;

            await _repo.Update(plan);
            return true;
        }
    }
}
