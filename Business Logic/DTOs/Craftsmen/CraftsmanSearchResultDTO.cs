namespace BusinessLogic.DTOs.Craftsmen
{
    public class CraftsmanSearchResultDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string FullName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? ProfileImageUrl { get; set; }

        public string? GovernorateName { get; set; }
        public string? CityName { get; set; }

        public int ProfessionId { get; set; }
        public string? ProfessionName { get; set; }

        public int ExperienceYears { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        public bool IsVerified { get; set; }
    }
}
