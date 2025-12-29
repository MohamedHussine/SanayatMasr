using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedReviews(ModelBuilder modelBuilder)
        {
            var reviews = new List<Review>();
            var baseDate = new DateTime(2024, 1, 1);
            int id = 1;

            // Create 120 reviews
            for (int i = 0; i < 120; i++)
            {
                int craftsmanId = (i % 30) + 1;

                // Every 10th review is a guest review (UserId = null)
                // Other reviews are written by Customers only (UserId >= 32)
                int? userId =
                    (i % 10 == 0)
                        ? null
                        : 32 + (i % 18); // Customers range from SeedUsers

                // Stars pattern: 3,4,5,3,4,5...
                int stars = (i % 3) + 3;

                reviews.Add(new Review
                {
                    Id = id++,
                    CraftsmanId = craftsmanId,
                    UserId = userId,

                    Stars = stars,
                    Comment = $"Review #{i + 1} for craftsman {craftsmanId}",

                    // Verified pattern (deterministic)
                    IsVerified = (i % 4 != 0),

                    // All reviews approved for demo
                    IsApproved = true,

                    CreatedAt = baseDate.AddDays(i),
                    UpdatedAt = baseDate.AddDays(i)
                });
            }

            modelBuilder.Entity<Review>().HasData(reviews);
        }
    }
}
