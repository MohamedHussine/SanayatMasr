using AutoMapper;
using BusinessLogic.DTOs.Review;
using BusinessLogic.DTOs.Reviews;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IGeneralRepository<Review> _repo;
        private readonly IMapper _mapper;

        public ReviewService(
            IGeneralRepository<Review> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetReviewDTO>> GetByCraftsmanAsync(int craftsmanId)
        {
            var reviews = await _repo.GetAll()
                .Include(r => r.Reviewer)
                .Include(r => r.Craftsman)
                .Where(r =>
                    r.CraftsmanId == craftsmanId &&
                    r.IsApproved &&
                    !r.IsDeleted)
                .ToListAsync();

            return _mapper.Map<IEnumerable<GetReviewDTO>>(reviews);
        }

        // ✅ GET ALL REVIEWS (ADMIN)
        public async Task<IEnumerable<GetReviewDTO>> GetAllAsync()
        {
            var reviews = await _repo.GetAll()
                .Include(r => r.Reviewer)
                .Include(r => r.Craftsman)
                .Where(r => !r.IsDeleted)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return _mapper.Map<IEnumerable<GetReviewDTO>>(reviews);
        }

        public async Task AddAsync(int craftsmanId, int userId, AddReviewDTO dto)
        {
            var review = new Review
            {
                CraftsmanId = craftsmanId,
                UserId = userId,
                Stars = dto.Stars,
                Comment = dto.Comment,
                IsApproved = true,
                IsVerified = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _repo.Add(review);
        }

        public async Task VerifyAsync(int reviewId)
        {
            var review = await _repo.GetByIDWithTracking(reviewId)
                ?? throw new Exception("Review not found");

            review.IsVerified = true;
            review.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(review);
        }

        public async Task DeleteAsync(int reviewId)
        {
            await _repo.Delete(reviewId);
        }

        public async Task<double> GetAverageAsync(int craftsmanId)
        {
            var avg = await _repo.GetAll()
                .Where(r =>
                    r.CraftsmanId == craftsmanId &&
                    r.IsApproved &&
                    !r.IsDeleted)
                .Select(r => (double?)r.Stars)
                .AverageAsync();

            return avg ?? 0;
        }
    }
}
