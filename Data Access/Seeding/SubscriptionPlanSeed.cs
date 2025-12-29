using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedSubscriptionPlans(ModelBuilder modelBuilder)
        {
            // Fixed date for migration consistency
            var baseDate = new DateTime(2024, 1, 1);

            var plans = new List<SubscriptionPlan>
            {
                // =========================
                // Free Plan
                // =========================
                new SubscriptionPlan
                {
                    Id = 1,
                    Name = "Free",
                    ArabicName = "مجاني",
                    Price = 0m,

                    // NOTE:
                    // DurationDays = 0 means no expiration (handled in business logic)
                    DurationDays = 0,

                    Features = "Free listing (limited)",
                    IsActive = true,

                    CreatedAt = baseDate,
                    UpdatedAt = baseDate
                },

                // =========================
                // Basic Plan
                // =========================
                new SubscriptionPlan
                {
                    Id = 2,
                    Name = "Basic",
                    ArabicName = "أساسي",
                    Price = 50m,
                    DurationDays = 30,
                    Features = "Standard listing + contact",
                    IsActive = true,

                    CreatedAt = baseDate,
                    UpdatedAt = baseDate
                },

                // =========================
                // Premium Plan
                // =========================
                new SubscriptionPlan
                {
                    Id = 3,
                    Name = "Premium",
                    ArabicName = "مميز",
                    Price = 200m,
                    DurationDays = 30,
                    Features = "Featured listing + top search",
                    IsActive = true,

                    CreatedAt = baseDate,
                    UpdatedAt = baseDate
                }
            };

            modelBuilder.Entity<SubscriptionPlan>().HasData(plans);
        }
    }
}
