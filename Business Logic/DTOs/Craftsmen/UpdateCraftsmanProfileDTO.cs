using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Craftsmen
{
    public class UpdateCraftsmanProfileDTO
    {
        // ================= USER =================
        [Required, MinLength(3)]
        public string FullName { get; set; } = string.Empty;

        public string? Phone { get; set; }

        [Required]
        public int GovernorateId { get; set; }

        [Required]
        public int CityId { get; set; }

        // ================= CRAFTSMAN =================
        [Required]
        public int ProfessionId { get; set; }

        [Required, MinLength(10)]
        public string Bio { get; set; } = string.Empty;

        [Range(0, 50)]
        public int ExperienceYears { get; set; }

        [Range(0, 100000)]
        public decimal MinPrice { get; set; }

        [Range(0, 100000)]
        public decimal MaxPrice { get; set; }
    }
}
