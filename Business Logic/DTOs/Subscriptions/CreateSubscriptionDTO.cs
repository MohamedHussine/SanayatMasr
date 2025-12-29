using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Subscriptions
{
    public class CreateSubscriptionDTO
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid PlanId")]
        public int PlanId { get; set; }
    }
}
