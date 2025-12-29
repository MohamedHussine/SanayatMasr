namespace BusinessLogic.DTOs.Review
{
    public class GetReviewDTO
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public string Comment { get; set; }
        public bool IsVerified { get; set; }

        public string? ReviewerName { get; set; }
    }
}
