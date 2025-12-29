using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    { 
        public static void SeedUsers(ModelBuilder modelBuilder)
        {
            var baseDate = new DateTime(2024, 1, 1);
            var users = new List<User>();

            // ===================== ADMIN =====================
            users.Add(new User
            {
                Id = 1,
                FullName = "Admin",
                Email = "admin@gmail.com",
                PasswordHash = "O2Esdae1BIpDX7bsgeUv+S1teVqLWpwXBw9qY8l6U7I=",
                Phone = "01000000000",
                Role = "Admin",
                IsActive = true,
                ProfileImage = "default-user.png",
                GovernorateId = null,
                CityId = null,
                CreatedAt = baseDate,
                UpdatedAt = baseDate
            });

            // ===================== NAME PARTS =====================
            var firstNames = new[]
            {
        "أحمد","محمد","محمود","عبدالله","عمر","كريم","سارة","نور",
        "هند","ليلى","منى","إيهاب","مروة","طارق","علي","يوسف",
        "عائشة","مريم","خالد","إبراهيم"
    };

            var middleNames = new[]
            {
        "محمد","حسن","إبراهيم","محمود","عبدالرحمن","مصطفى","ياسر",
        "سامي","فؤاد","خليل","عادل","سعيد","سمير","كمال","حسين"
    };

            var lastNames = new[]
            {
        "علي","حسن","إبراهيم","محمود","سامي","صلاح","مصطفى",
        "عبدالله","فؤاد","ياسين","سعيد","سمير","عادل","حسين","كمال"
    };

            const int craftsmenCount = 160;
            int id = 2;

            // ===================== CRAFTSMEN USERS =====================
            for (int i = 0; i < craftsmenCount; i++)
            {
                var fullName =
                    $"{firstNames[i % firstNames.Length]} " +
                    $"{middleNames[(i / firstNames.Length) % middleNames.Length]} " +
                    $"{lastNames[(i / (firstNames.Length * middleNames.Length)) % lastNames.Length]}";

                users.Add(new User
                {
                    Id = id,
                    FullName = fullName,
                    Email = $"craftsman{id}@example.com",
                    PasswordHash = "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=",
                    Phone = $"010{id:00000000}",
                    Role = "Craftsman",
                    IsActive = true,
                    ProfileImage = "default-user.png",
                    GovernorateId = 1,
                    CityId = (id % 5) + 1,
                    CreatedAt = baseDate,
                    UpdatedAt = baseDate
                });

                id++;
            }

            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
