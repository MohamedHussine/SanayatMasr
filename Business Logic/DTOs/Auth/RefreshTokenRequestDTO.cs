using System.ComponentModel.DataAnnotations;

public class RefreshTokenRequestDTO
{
    [Required]
    public string RefreshToken { get; set; }
}
