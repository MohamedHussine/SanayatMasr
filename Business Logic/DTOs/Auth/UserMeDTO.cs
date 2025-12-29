namespace BusinessLogic.DTOs.Auth
{
  
    public class UserMeDTO
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;

        
        public string? ProfileImageUrl { get; set; }
    }
}
