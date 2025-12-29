namespace BusinessLogic.DTOs.Auth
{
    public class AuthResponseDTO
    {
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpiresAt { get; set; }

        public string RefreshToken { get; set; }
        public string Role { get; set; }
        public string FullName { get; set; }
    }

}
