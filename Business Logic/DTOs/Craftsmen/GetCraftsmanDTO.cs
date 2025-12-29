namespace BusinessLogic.DTOs.Craftsmen
{
    /// <summary>
    /// Craftsman Response DTO (Read Only)
    /// </summary>
    public class GetCraftsmanDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        // ======================
        // User Info
        // ======================
        public string FullName { get; set; } = string.Empty;

        // NEW (from User table)
        public string? Phone { get; set; }
        public string? ProfileImageUrl { get; set; }

        // ======================
        // Location
        // ======================
        public string? GovernorateName { get; set; }
        public string? CityName { get; set; }

        // ======================
        // Craftsman Info
        // ======================
        public int ProfessionId { get; set; }

        public string Bio { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }

        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        public bool IsVerified { get; set; }
        public DateTime? VerificationDate { get; set; }
    }
}
