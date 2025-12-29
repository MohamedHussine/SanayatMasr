using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Reviews
{
    public class AddReviewDTO 
    {
        [Range(1, 5, ErrorMessage = "Stars must be between 1 and 5")]
        public int Stars { get; set; }

        [Required]
        [MinLength(1)]
        public string Comment { get; set; } = null!;
    }
}
