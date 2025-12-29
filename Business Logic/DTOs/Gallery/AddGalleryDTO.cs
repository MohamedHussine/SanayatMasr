using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Gallery
{
    // DTO لإضافة صورة/فيديو جديد
    public class AddGalleryDTO
    {
        [Required]
        public string MediaUrl { get; set; } = null!;

        [Required]
        [RegularExpression("Image|Video", ErrorMessage = "MediaType must be Image or Video")]
        public string MediaType { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!;

        [StringLength(500)]
        public string Description { get; set; } = null!;
    }
}
