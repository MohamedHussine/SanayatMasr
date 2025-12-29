using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCraftsmanSubscriptions(ModelBuilder modelBuilder)
        {
            var list = new List<CraftsmanSubscription>();
            int id = 1;

            // Fixed base date (Migration-safe)
            var startBase = new DateTime(2024, 1, 1);

            // Craftsmen: 1 -> 20 (demo subset)
            for (int craftsmanId = 1; craftsmanId <= 20; craftsmanId++)
            {
                var startDate = startBase.AddDays(craftsmanId * 2);
                var endDate = startDate.AddDays(30);

                bool isActive = endDate > startBase;

                list.Add(new CraftsmanSubscription
                {
                    Id = id++,
                    CraftsmanId = craftsmanId,

                    // Alternate plans for demo:
                    // Odd  -> Premium
                    // Even -> Basic
                    PlanId = (craftsmanId % 2 == 0) ? 2 : 3,

                    StartDate = startDate,
                    EndDate = endDate,

                    IsActive = isActive,
                    Status = isActive ? "Active" : "Expired",

                    CreatedAt = startDate,
                    UpdatedAt = startDate
                });
            }

            modelBuilder.Entity<CraftsmanSubscription>().HasData(list);
        }
    }
}
