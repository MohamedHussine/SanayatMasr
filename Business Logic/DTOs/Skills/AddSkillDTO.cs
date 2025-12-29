using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Skills
{
    // DTO لإضافة مهارة جديدة
    public class AddSkillDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "ArabicName is required")]
        [MinLength(3)]
        public string ArabicName { get; set; } = null!;
    }
}
