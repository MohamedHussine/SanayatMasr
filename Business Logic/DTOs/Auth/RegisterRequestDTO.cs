using System.ComponentModel.DataAnnotations;

public class RegisterRequestDTO
{
    [Required, EmailAddress]
    public string Email { get; set; }

    [Required, MinLength(6)]
    public string Password { get; set; }

    [Required]
    public string FullName { get; set; }

    public string? Phone { get; set; }

    [Required]
    public string Role { get; set; } // User / Craftsman / Admin

    public int? GovernorateId { get; set; }
    public int? CityId { get; set; }
}
