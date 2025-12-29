using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Professions
{
    // DTO لتعديل مهنة
    public class UpdateProfessionDTO
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
