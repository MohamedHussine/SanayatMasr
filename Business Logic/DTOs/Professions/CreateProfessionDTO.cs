using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Professions
{
    // DTO لإنشاء مهنة جديدة
    public class CreateProfessionDTO
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string ArabicName { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }
    }
}
