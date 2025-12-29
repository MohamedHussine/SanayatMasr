using BusinessLogic.DTOs.SubscriptionPlans;

namespace BusinessLogic.Interfaces
{
    public interface ISubscriptionPlanService
    {
        Task<IEnumerable<GetSubscriptionPlanDTO>> GetAllAsync();
        Task<GetSubscriptionPlanDTO?> GetByIdAsync(int id);

        Task<int> CreateAsync(CreateSubscriptionPlanDTO dto, string createdBy);
        Task<bool> UpdateAsync(int id, UpdateSubscriptionPlanDTO dto, string updatedBy);
        Task<bool> DeleteAsync(int id, string deletedBy);
    }
}
