using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedReports(ModelBuilder modelBuilder)
        {
            var reports = new List<Report>();
            var baseDate = new DateTime(2024, 1, 1);
            int id = 1;

            // Create 40 reports
            for (int i = 0; i < 40; i++)
            {
                int craftsmanId = (i % 30) + 1;

                // Customers only (from SeedUsers: IDs >= 32)
                int reporterUserId = 32 + (i % 18);

                bool isResolved = (i % 3 != 0);

                reports.Add(new Report
                {
                    Id = id++,
                    CraftsmanId = craftsmanId,
                    ReporterUserId = reporterUserId,

                    Message = $"بلاغ رقم {i + 1} بسبب سوء تعامل",

                    Status = isResolved ? "Resolved" : "Pending",
                    IsResolved = isResolved,

                    CreatedAt = baseDate.AddDays(i),
                    UpdatedAt = baseDate.AddDays(i)
                });
            }

            modelBuilder.Entity<Report>().HasData(reports);
        }
    }
}
