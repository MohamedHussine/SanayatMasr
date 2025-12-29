
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.Helpers.Enums;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        
        public static void SeedCraftsmanSkills(ModelBuilder modelBuilder)
        {
            var list = new List<CraftsmanSkill>();
            var now = new DateTime(2024, 1, 1);
            int id = 1;

            // ================================
            // HARD CONSTRAINTS
            // ================================
            // Craftsmen IDs : 1 -> 30
            // Skills IDs    : 1 -> 60 (MUST match SeedSkills)
            const int craftsmanCount = 30;
            const int skillCount = 60;

            for (int craftsmanId = 1; craftsmanId <= craftsmanCount; craftsmanId++)
            {
                // كل Craftsman له 3 Skills فقط
                for (int offset = 0; offset < 3; offset++)
                {
                    // 🔒 SkillId مضمون (1 -> 60)
                    int skillId = ((craftsmanId - 1) * 3 + offset) % skillCount + 1;

                    var level = offset switch
                    {
                        0 => ProficiencyLevel.Beginner,
                        1 => ProficiencyLevel.Intermediate,
                        _ => ProficiencyLevel.Expert
                    };

                    list.Add(new CraftsmanSkill
                    {
                        Id = id++,
                        CraftsmanId = craftsmanId,
                        SkillId = skillId,
                        ProficiencyLevel = level,

                        IsDeleted = false,
                        CreatedAt = now,
                        UpdatedAt = now
                    });
                }
            }

            modelBuilder.Entity<CraftsmanSkill>().HasData(list);

        }
    }
}
