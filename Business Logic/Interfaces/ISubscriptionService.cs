using BusinessLogic.DTOs.Subscriptions;

namespace BusinessLogic.Interfaces
{
    public interface ISubscriptionService
    {
        // GET /api/craftsmen/{craftsmanId}/subscriptions
        Task<IEnumerable<SubscriptionResponseDTO>> GetByCraftsmanAsync(int craftsmanId);

        // POST /api/craftsmen/{craftsmanId}/subscriptions
        Task<SubscriptionResponseDTO> CreateAsync(int craftsmanId,CreateSubscriptionDTO dto);

        // PUT /api/subscriptions/{id}/cancel
        Task<bool> CancelAsync(int id);
    }
}
