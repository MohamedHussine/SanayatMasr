using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
      
        public static void SeedCraftsmen(ModelBuilder modelBuilder)
        {
            var list = new List<Craftsman>();
            var baseDate = new DateTime(2024, 1, 1);

            var professionNames = new Dictionary<int, string>
    {
        { 1, "فني تكييف" },
        { 2, "نجار" },
        { 3, "كهربائي" },
        { 4, "سباك" },
        { 5, "إصلاح أجهزة" },
        { 6, "فني غاز" },
        { 7, "فني ألوميتال" },
        { 8, "نقاش" }
    };

            int craftsmanId = 1;
            int userId = 2;

            for (int professionId = 1; professionId <= 8; professionId++)
            {
                for (int i = 0; i < 20; i++)
                {
                    bool isVerified = craftsmanId % 3 == 0;

                    list.Add(new Craftsman
                    {
                        Id = craftsmanId,
                        UserId = userId,
                        ProfessionId = professionId,

                        Bio = $"صنايعي {professionNames[professionId]} خبرة أكثر من {1 + (i % 15)} سنة",
                        ExperienceYears = 1 + (i % 15),
                        MinPrice = 100 + (i * 20),
                        MaxPrice = 400 + (i * 20),

                        IsVerified = isVerified,
                        VerificationDate = isVerified ? baseDate : null,
                        CreatedAt = baseDate,
                        UpdatedAt = baseDate
                    });

                    craftsmanId++;
                    userId++;
                }
            }

            modelBuilder.Entity<Craftsman>().HasData(list);
        }
    }
}
