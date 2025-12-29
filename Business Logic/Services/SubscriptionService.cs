using AutoMapper;
using BusinessLogic.DTOs.Subscriptions;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly IGeneralRepository<CraftsmanSubscription> _repo;
        private readonly IGeneralRepository<SubscriptionPlan> _planRepo;
        private readonly IMapper _mapper;

        public SubscriptionService(
            IGeneralRepository<CraftsmanSubscription> repo,
            IGeneralRepository<SubscriptionPlan> planRepo,
            IMapper mapper)
        {
            _repo = repo;
            _planRepo = planRepo;
            _mapper = mapper;
        }

        // GET /api/craftsmen/{craftsmanId}/subscriptions
        public async Task<IEnumerable<SubscriptionResponseDTO>> GetByCraftsmanAsync(int craftsmanId)
        {
            var subs = await _repo.GetAll()
                .Include(x => x.Plan)
                .Where(x => x.CraftsmanId == craftsmanId)
                .ToListAsync();

            return _mapper.Map<IEnumerable<SubscriptionResponseDTO>>(subs);
        }

        // POST /api/craftsmen/{craftsmanId}/subscriptions
        public async Task<SubscriptionResponseDTO> CreateAsync(
            int craftsmanId,
            CreateSubscriptionDTO dto)
        {
            // ✅ IMPORTANT FIX (GetByID)
            var plan = await _planRepo.GetByID(dto.PlanId);
            if (plan == null || !plan.IsActive)
                throw new Exception("Invalid subscription plan");

            // ❌ Prevent multiple active subscriptions
            var hasActive = await _repo.GetAll()
                .AnyAsync(x => x.CraftsmanId == craftsmanId && x.IsActive);

            if (hasActive)
                throw new Exception("Craftsman already has active subscription");

            var startDate = DateTime.UtcNow;
            var endDate = plan.DurationDays == 0
                ? startDate
                : startDate.AddDays(plan.DurationDays);

            var entity = new CraftsmanSubscription
            {
                CraftsmanId = craftsmanId,
                PlanId = plan.Id,
                StartDate = startDate,
                EndDate = endDate,
                IsActive = true,
                Status = "Active"
            };

            await _repo.Add(entity);

            // attach for mapper
            entity.Plan = plan;

            return _mapper.Map<SubscriptionResponseDTO>(entity);
        }

        // PUT /api/subscriptions/{id}/cancel
        public async Task<bool> CancelAsync(int id)
        {
            var sub = await _repo.GetByIDWithTracking(id);
            if (sub == null) return false;

            sub.IsActive = false;
            sub.Status = "Cancelled";
            sub.EndDate = DateTime.UtcNow;

            await _repo.Update(sub);
            return true;
        }
    }
}
