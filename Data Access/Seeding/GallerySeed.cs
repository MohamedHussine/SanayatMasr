using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedGalleries(ModelBuilder modelBuilder)
        {
            var list = new List<Gallery>();
            int id = 1;

            // Fixed base date (Migration-safe)
            var baseDate = new DateTime(2024, 1, 10);

            // Craftsman IDs: 1 -> 30
            for (int craftsmanId = 1; craftsmanId <= 30; craftsmanId++)
            {
                // Spread creation dates for realistic demo data
                var created = baseDate.AddDays(craftsmanId);

                // Each craftsman has 3 images
                for (int img = 1; img <= 3; img++)
                {
                    list.Add(new Gallery
                    {
                        Id = id++,
                        CraftsmanId = craftsmanId,

                        MediaUrl = $"/uploads/gallery/c{craftsmanId}_{img}.jpg",
                        MediaType = "Image",

                        Title = $"Work sample {img}",
                        Description = $"Sample gallery image {img} for craftsman {craftsmanId}",

                        CreatedAt = created,
                        UpdatedAt = created
                    });
                }
            }

            modelBuilder.Entity<Gallery>().HasData(list);
        }
    }
}
