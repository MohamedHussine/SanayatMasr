
using DataAccess.Seeding;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // =====================================================
            // 1️⃣ MASTER / LOOKUP DATA (NO FOREIGN KEYS)
            // =====================================================
            SeedGovernorates(modelBuilder);        // Required by Cities
            SeedCities(modelBuilder);              // Required by Users / CraftsmanCities

            SeedProfessions(modelBuilder);         // Required by Craftsmen
            SeedSkills(modelBuilder);              // Required by CraftsmanSkills
            SeedSubscriptionPlans(modelBuilder);   // Required by CraftsmanSubscriptions

            // =====================================================
            // 2️⃣ USERS & CORE PROFILES
            // =====================================================
            SeedUsers(modelBuilder);               // Admin, Craftsmen users, Customers
            SeedCraftsmen(modelBuilder);           // Depends on Users + Professions

            // =====================================================
            // 3️⃣ RELATION TABLES (MANY-TO-MANY)
            // =====================================================
            SeedCraftsmanCities(modelBuilder);     // Depends on Craftsmen + Cities
            SeedCraftsmanSkills(modelBuilder);     // Depends on Craftsmen + Skills

            // =====================================================
            // 4️⃣ SUBSCRIPTIONS & PAYMENTS
            // =====================================================
            SeedCraftsmanSubscriptions(modelBuilder); // Depends on Craftsmen + Plans
            SeedPayments(modelBuilder);                // Depends on Subscriptions

            // =====================================================
            // 5️⃣ CONTENT
            // =====================================================
            SeedGalleries(modelBuilder);           // Depends on Craftsmen

            // =====================================================
            // 6️⃣ FEEDBACK & MODERATION
            // =====================================================
            SeedReviews(modelBuilder);             // Depends on Craftsmen + Users
            SeedReports(modelBuilder);             // Depends on Craftsmen + Users


        }
    }
}
