using System.ComponentModel.DataAnnotations;
namespace Entities.Models
{
    public class User : BaseModel
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? ProfileImage { get; set; }

        [Required]
        public string Role { get; set; } = "User";
        public bool IsActive { get; set; } = true;

        // ===== Location =====
        public int? GovernorateId { get; set; }
        public Governorate? Governorate { get; set; }

        public int? CityId { get; set; }
        public City? City { get; set; }

        // =========================
        // Navigation Properties
        // =========================

        // User (1) ---> (Many) Craftsman Profiles
        public virtual ICollection<Craftsman> CraftsmenProfiles { get; set; }
            = new HashSet<Craftsman>();

        // User (1) ---> (Many) Reports
        public virtual ICollection<Report> ReportsFiled { get; set; }
            = new HashSet<Report>();

        // User (1) ---> (Many) Reviews
        public virtual ICollection<Review> ReviewsWritten { get; set; }
            = new HashSet<Review>();
    }
}
