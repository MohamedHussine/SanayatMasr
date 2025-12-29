namespace BusinessLogic.DTOs.Users
{
    public class UserSearchResultDTO
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string Role { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string? ProfileImage { get; set; }

        public string? GovernorateName { get; set; }
        public string? CityName { get; set; }
    }
}
