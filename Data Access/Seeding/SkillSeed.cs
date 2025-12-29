using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedSkills(ModelBuilder modelBuilder)
        {
            // Fixed date for migration consistency
            // Fixed date for migration consistency
            var baseDate = new DateTime(2024, 1, 1);

            var skills = new List<Skill>();
            int id = 1;

            void Add(string en, string ar)
            {
                skills.Add(new Skill
                {
                    Id = id++,
                    Name = en,
                    ArabicName = ar,
                    IsDeleted = false,
                    CreatedAt = baseDate,
                    UpdatedAt = baseDate
                });
            }

            // =========================
            // Electrical
            // =========================
            Add("Wiring", "تمديدات كهرباء");
            Add("Circuit Diagnosis", "تشخيص الدوائر الكهربائية");
            Add("Panel Installation", "تركيب لوحات كهرباء");
            Add("Lighting", "تركيب إضاءة");
            Add("Power Outlets", "تركيب مخارج كهرباء");

            // =========================
            // Plumbing
            // =========================
            Add("Pipe Fixing", "إصلاح مواسير");
            Add("Drain Unclog", "تسليك صرف");
            Add("Faucet Repair", "إصلاح حنفيات");

            // =========================
            // Welding / Metal
            // =========================
            Add("Soldering", "لحام");

            // =========================
            // Carpentry
            // =========================
            Add("Wood Cutting", "تقطيع خشب");
            Add("Cabinet Making", "تصنيع خزائن");
            Add("Door Repair", "إصلاح أبواب");

            // =========================
            // Painting
            // =========================
            Add("Interior Painting", "دهانات داخلية");
            Add("Exterior Painting", "دهانات خارجية");

            // =========================
            // AC / HVAC
            // =========================
            Add("AC Repair", "إصلاح تكييف");
            Add("AC Gas Recharge", "شحن فريون تكييف");

            // =========================
            // Flooring / Ceramic
            // =========================
            Add("Tile Laying", "تركيب بلاط");
            Add("Grouting", "ملء فواصل البلاط");

            // =========================
            // Fill gaps (Generic skills)
            // =========================
            while (skills.Count < 20)
                Add($"General Skill {skills.Count + 1}", $"مهارة عامة {skills.Count + 1}");

            // =========================
            // Security / Locks
            // =========================
            Add("Lock Installation", "تركيب أقفال");
            Add("Lock Repair", "إصلاح أقفال");

            while (skills.Count < 40)
                Add($"General Skill {skills.Count + 1}", $"مهارة عامة {skills.Count + 1}");

            // =========================
            // Home Appliances
            // =========================
            Add("Fridge Repair", "إصلاح ثلاجات");
            Add("Washing Machine Repair", "إصلاح غسالات");
            Add("Oven Repair", "إصلاح أفران");
            Add("Microwave Repair", "إصلاح ميكروويف");

            while (skills.Count < 47)
                Add($"General Skill {skills.Count + 1}", $"مهارة عامة {skills.Count + 1}");

            // =========================
            // Smart / Modern Services
            // =========================
            Add("Smart Home Install", "تركيب أنظمة منزل ذكي");

            while (skills.Count < 51)
                Add($"General Skill {skills.Count + 1}", $"مهارة عامة {skills.Count + 1}");

            Add("Solar Panel Install", "تركيب ألواح شمسية");

            while (skills.Count < 54)
                Add($"General Skill {skills.Count + 1}", $"مهارة عامة {skills.Count + 1}");

            Add("Security Camera Install", "تركيب كاميرات مراقبة");

            while (skills.Count < 58)
                Add($"General Skill {skills.Count + 1}", $"مهارة عامة {skills.Count + 1}");

            // =========================
            // Renovation
            // =========================
            Add("Bathroom Renovation", "تجديد حمامات");
            Add("Kitchen Renovation", "تجديد مطابخ");

            modelBuilder.Entity<Skill>().HasData(skills);
        }
    }
}
