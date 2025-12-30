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
                int reporterUserId = 32 + (i % 18);
                bool isResolved = (i % 3 != 0);

                reports.Add(new Report
                {
                    Id = id++, // هنا الـ id بيبدأ من 1 لـ 40
                    CraftsmanId = craftsmanId,
                    ReporterUserId = reporterUserId,
                    Message = $"بلاغ رقم {i + 1} بسبب سوء تعامل",
                    Status = isResolved ? "Resolved" : "Pending",
                    IsResolved = isResolved,
                    CreatedAt = baseDate.AddDays(i),
                    UpdatedAt = baseDate.AddDays(i)
                });
            }

            // إضافة التقرير الإضافي بشكل صحيح
            reports.Add(new Report
            {
                Id = id++, // هياخد رقم 41 أوتوماتيك
                Message = "First Report",
                ReporterUserId = 4,
                CraftsmanId = 1, // تأكد من إضافة الـ CraftsmanId لو كان مطلوب (Required)
                Status = "Pending",
                CreatedAt = baseDate,
                UpdatedAt = baseDate
            });

            // تمرير القائمة كاملة لـ HasData
            //modelBuilder.Entity<Report>().HasData(reports);
            modelBuilder.Entity<Report>()
    .HasOne(r => r.Reporter)
    .WithMany(u => u.ReportsFiled) // تأكد من وجود هذه الخاصية في كلاس User
    .HasForeignKey(r => r.ReporterUserId); // تأكد أن الاسم هنا مطابق للكلاس

        }
    }
}
