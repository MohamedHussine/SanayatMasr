using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.SubscriptionPlans
{
    public class UpdateSubscriptionPlanDTO
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string ArabicName { get; set; } = null!;

        public decimal Price { get; set; }
        public int DurationDays { get; set; }
        public string Features { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
