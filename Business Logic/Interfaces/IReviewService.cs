using BusinessLogic.DTOs.Review;
using BusinessLogic.DTOs.Reviews;

namespace BusinessLogic.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<GetReviewDTO>> GetByCraftsmanAsync(int craftsmanId);

        Task<IEnumerable<GetReviewDTO>> GetAllAsync(); // ✅ NEW

        Task AddAsync(int craftsmanId, int userId, AddReviewDTO dto);

        Task VerifyAsync(int reviewId);

        Task DeleteAsync(int reviewId);

        Task<double> GetAverageAsync(int craftsmanId);
    }
}
