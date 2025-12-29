namespace BusinessLogic.DTOs.Payments
{
    public class PaymentResponseDTO
    {
        public int Id { get; set; }

        public int SubscriptionId { get; set; }

        public int CraftsmanId { get; set; } 

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string PaymentMethod { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
