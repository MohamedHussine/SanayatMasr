namespace BusinessLogic.DTOs.SubscriptionPlans
{
    public class GetSubscriptionPlanDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public decimal Price { get; set; }
        public int DurationDays { get; set; }
        public string Features { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
