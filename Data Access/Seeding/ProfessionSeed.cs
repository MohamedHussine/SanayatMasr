using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedProfessions(ModelBuilder modelBuilder)
        {
            var baseDate = new DateTime(2024, 1, 1);

            var list = new List<Profession>
    {
        new Profession
        {
            Id = 1,
            Name = "Plumber",
            ArabicName = "سباك",
            Description = "Plumbing and installations",
            CreatedAt = baseDate,
            UpdatedAt = baseDate
        },
        new Profession
        {
            Id = 2,
            Name = "Electrician",
            ArabicName = "كهربائي",
            Description = "Electrical maintenance and wiring",
            CreatedAt = baseDate,
            UpdatedAt = baseDate
        },
        new Profession
        {
            Id = 3,
            Name = "Carpenter",
            ArabicName = "نجار",
            Description = "Wood works and furniture",
            CreatedAt = baseDate,
            UpdatedAt = baseDate
        },
        new Profession
        {
            Id = 4,
            Name = "AC Technician",
            ArabicName = "فني تكييف",
            Description = "AC maintenance and installation",
            CreatedAt = baseDate,
            UpdatedAt = baseDate
        },
        new Profession
        {
            Id = 5,
            Name = "Painter",
            ArabicName = "نقاش",
            Description = "Painting and finishing works",
            CreatedAt = baseDate,
            UpdatedAt = baseDate
        },
        new Profession
        {
            Id = 6,
            Name = "Aluminum Installer",
            ArabicName = "فني ألوميتال",
            Description = "Aluminum kitchens and windows",
            CreatedAt = baseDate,
            UpdatedAt = baseDate
        },
        new Profession
        {
            Id = 7,
            Name = "Gas Technician",
            ArabicName = "فني غاز",
            Description = "Gas systems maintenance and installation",
            CreatedAt = baseDate,
            UpdatedAt = baseDate
        },
        new Profession
        {
            Id = 8,
            Name = "Appliance Repair",
            ArabicName = "إصلاح أجهزة",
            Description = "Repair of home appliances",
            CreatedAt = baseDate,
            UpdatedAt = baseDate
        }
    };

            modelBuilder.Entity<Profession>().HasData(list);
        }
    }
}
