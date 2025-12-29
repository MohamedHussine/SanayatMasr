using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
       
      
        public static void SeedGovernorates(ModelBuilder modelBuilder)
        {
            // Fixed date for migration consistency
            var baseDate = new DateTime(2024, 1, 1);

            var data = new List<Governorate>
            {
                // =========================
                // Greater Cairo
                // =========================
                new Governorate { Id = 1, Name = "Cairo", ArabicName = "القاهرة", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 2, Name = "Giza", ArabicName = "الجيزة", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 3, Name = "Qalyubia", ArabicName = "القليوبية", CreatedAt = baseDate, UpdatedAt = baseDate },

                // =========================
                // Canal cities
                // =========================
                new Governorate { Id = 4, Name = "Suez", ArabicName = "السويس", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 5, Name = "Port Said", ArabicName = "بورسعيد", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 6, Name = "Ismailia", ArabicName = "الإسماعيلية", CreatedAt = baseDate, UpdatedAt = baseDate },

                // =========================
                // Delta
                // =========================
                new Governorate { Id = 7, Name = "Dakahlia", ArabicName = "الدقهلية", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 8, Name = "Sharqia", ArabicName = "الشرقية", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 9, Name = "Gharbia", ArabicName = "الغربية", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 10, Name = "Monufia", ArabicName = "المنوفية", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 11, Name = "Beheira", ArabicName = "البحيرة", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 12, Name = "Kafr El Sheikh", ArabicName = "كفر الشيخ", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 13, Name = "Damietta", ArabicName = "دمياط", CreatedAt = baseDate, UpdatedAt = baseDate },

                // =========================
                // Upper Egypt
                // =========================
                new Governorate { Id = 14, Name = "Fayoum", ArabicName = "الفيوم", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 15, Name = "Beni Suef", ArabicName = "بني سويف", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 16, Name = "Minya", ArabicName = "المنيا", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 17, Name = "Asyut", ArabicName = "أسيوط", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 18, Name = "Sohag", ArabicName = "سوهاج", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 19, Name = "Qena", ArabicName = "قنا", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 20, Name = "Luxor", ArabicName = "الأقصر", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 21, Name = "Aswan", ArabicName = "أسوان", CreatedAt = baseDate, UpdatedAt = baseDate },

                // =========================
                // Frontier governorates
                // =========================
                new Governorate { Id = 22, Name = "Red Sea", ArabicName = "البحر الأحمر", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 23, Name = "New Valley", ArabicName = "الوادي الجديد", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 24, Name = "Matrouh", ArabicName = "مطروح", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 25, Name = "North Sinai", ArabicName = "شمال سيناء", CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 26, Name = "South Sinai", ArabicName = "جنوب سيناء", CreatedAt = baseDate, UpdatedAt = baseDate }
            };

            modelBuilder.Entity<Governorate>().HasData(data);
        }
    }
}
