using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
       
        public static void SeedCities(ModelBuilder modelBuilder)
        {
            var now = new DateTime(2024, 1, 1);

            var cities = new List<City>
            {
                // =========================
                // Cairo (GovernorateId = 1)
                // =========================
                new City { Id = 1, GovernorateId = 1, Name = "Nasr City", ArabicName = "مدينة نصر", Latitude = 30.0561m, Longitude = 31.3300m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 2, GovernorateId = 1, Name = "Heliopolis", ArabicName = "مصر الجديدة", Latitude = 30.0917m, Longitude = 31.3180m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 3, GovernorateId = 1, Name = "Maadi", ArabicName = "المعادي", Latitude = 29.9602m, Longitude = 31.2569m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 4, GovernorateId = 1, Name = "Zamalek", ArabicName = "الزمالك", Latitude = 30.0666m, Longitude = 31.2197m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Giza (GovernorateId = 2)
                // =========================
                new City { Id = 5, GovernorateId = 2, Name = "Dokki", ArabicName = "الدقي", Latitude = 30.0386m, Longitude = 31.2120m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 6, GovernorateId = 2, Name = "6th of October", ArabicName = "6 أكتوبر", Latitude = 29.9773m, Longitude = 30.9455m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 7, GovernorateId = 2, Name = "Sheikh Zayed", ArabicName = "الشيخ زايد", Latitude = 30.0215m, Longitude = 30.9886m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Alexandria (GovernorateId = 3)
                // =========================
                new City { Id = 8, GovernorateId = 3, Name = "Sidi Gaber", ArabicName = "سيدي جابر", Latitude = 31.2156m, Longitude = 29.9553m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 9, GovernorateId = 3, Name = "Smouha", ArabicName = "سموحة", Latitude = 31.2100m, Longitude = 29.9400m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 10, GovernorateId = 3, Name = "Stanley", ArabicName = "ستانلي", Latitude = 31.2358m, Longitude = 29.9662m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Dakahlia (GovernorateId = 7)
                // =========================
                new City { Id = 11, GovernorateId = 7, Name = "Mansoura", ArabicName = "المنصورة", Latitude = 31.0409m, Longitude = 31.3785m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 12, GovernorateId = 7, Name = "Talkha", ArabicName = "طلخا", Latitude = 31.0524m, Longitude = 31.3812m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Sharqia (GovernorateId = 8)
                // =========================
                new City { Id = 13, GovernorateId = 8, Name = "Zagazig", ArabicName = "الزقازيق", Latitude = 30.5877m, Longitude = 31.5020m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 14, GovernorateId = 8, Name = "Belbeis", ArabicName = "بلبيس", Latitude = 30.4181m, Longitude = 31.5622m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Red Sea (GovernorateId = 20)
                // =========================
                new City { Id = 15, GovernorateId = 20, Name = "Hurghada", ArabicName = "الغردقة", Latitude = 27.2579m, Longitude = 33.8116m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 16, GovernorateId = 20, Name = "Safaga", ArabicName = "سفاجا", Latitude = 26.7500m, Longitude = 33.9333m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 17, GovernorateId = 20, Name = "Marsa Alam", ArabicName = "مرسى علم", Latitude = 25.0699m, Longitude = 34.8900m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Luxor (GovernorateId = 18)
                // =========================
                new City { Id = 18, GovernorateId = 18, Name = "Luxor City", ArabicName = "الأقصر", Latitude = 25.6872m, Longitude = 32.6396m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Aswan (GovernorateId = 19)
                // =========================
                new City { Id = 19, GovernorateId = 19, Name = "Aswan City", ArabicName = "أسوان", Latitude = 24.0889m, Longitude = 32.8998m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Matrouh (GovernorateId = 22)
                // =========================
                new City { Id = 20, GovernorateId = 22, Name = "El Dabaa", ArabicName = "الضبعة", Latitude = 31.0460m, Longitude = 28.4400m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // South Sinai (GovernorateId = 24)
                // =========================
                new City { Id = 21, GovernorateId = 24, Name = "Sharm El-Sheikh", ArabicName = "شرم الشيخ", Latitude = 27.9158m, Longitude = 34.3299m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 22, GovernorateId = 24, Name = "Taba", ArabicName = "طابا", Latitude = 29.4920m, Longitude = 34.8947m, CreatedAt = now, UpdatedAt = now }
            };

            modelBuilder.Entity<City>().HasData(cities);
        }
    }
}
