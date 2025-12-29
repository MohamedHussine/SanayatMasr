using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.SubscriptionPlans
{
    public class CreateSubscriptionPlanDTO
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string ArabicName { get; set; } = null!;

        [Range(0, 100000)]
        public decimal Price { get; set; }

        public int DurationDays { get; set; }

        public string Features { get; set; } = null!;
    }
}
