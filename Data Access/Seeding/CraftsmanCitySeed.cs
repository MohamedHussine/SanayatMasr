using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
    
        public static void SeedCraftsmanCities(ModelBuilder modelBuilder)
        {
            var list = new List<CraftsmanCity>();
            var now = new DateTime(2024, 1, 1);
            int id = 1;

            // ⚠️ These City IDs MUST match SeedCities
            var cityIds = new[]
            {
                1,  2,  3,  4,  5,
                6,  7,  8,  9,  10,
                11, 12, 13, 14, 15,
                16, 17, 18, 19, 20
            };

            // Craftsman IDs: 1 -> 30
            for (int craftsmanId = 1; craftsmanId <= 30; craftsmanId++)
            {
                // =========================
                // Primary City (exactly one)
                // =========================
                int primaryCityId = cityIds[(craftsmanId - 1) % cityIds.Length];

                list.Add(new CraftsmanCity
                {
                    Id = id++,
                    CraftsmanId = craftsmanId,
                    CityId = primaryCityId,
                    IsPrimary = true,
                    CreatedAt = now,
                    UpdatedAt = now
                });

                // =========================
                // Secondary City (optional)
                // =========================
                // Every even craftsman gets ONE secondary city
                if (craftsmanId % 2 == 0)
                {
                    int secondaryCityId = cityIds[(craftsmanId + 3) % cityIds.Length];

                    // Prevent duplicate city assignment
                    if (secondaryCityId != primaryCityId)
                    {
                        list.Add(new CraftsmanCity
                        {
                            Id = id++,
                            CraftsmanId = craftsmanId,
                            CityId = secondaryCityId,
                            IsPrimary = false,
                            CreatedAt = now,
                            UpdatedAt = now
                        });
                    }
                }
            }

            modelBuilder.Entity<CraftsmanCity>().HasData(list);
        }
    }
}
