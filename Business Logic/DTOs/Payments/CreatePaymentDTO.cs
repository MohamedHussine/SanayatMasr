using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Payments
{
    public class CreatePaymentDTO
    {
        [Required(ErrorMessage = "SubscriptionId is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid SubscriptionId")]
        public int SubscriptionId { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(1, 100000, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Payment method is required")]
        [RegularExpression("Card|Cash|VodafoneCash",
            ErrorMessage = "PaymentMethod must be Card, Cash, or VodafoneCash")]
        public string PaymentMethod { get; set; }

        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; } = "EGP";

        [StringLength(100)]
        public string? ProviderReference { get; set; }
    }
}
