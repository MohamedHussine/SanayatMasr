using DataAccess.Seeding;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
            modelBuilder.Seed();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        public DbSet<City> Citys { get; set; }
        public DbSet<Governorate> Governorates { get; set; }

        public DbSet<Craftsman> Craftsmens { get; set; }
        public DbSet<CraftsmanCity> CraftsmansCity { get; set; }
        public DbSet<CraftsmanSkill> CraftsmansSkills { get; set; }
        public DbSet<CraftsmanSubscription> CraftsmansSubscriptions { get; set; }

        public DbSet<Gallery> Gallerys { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
    }
}
