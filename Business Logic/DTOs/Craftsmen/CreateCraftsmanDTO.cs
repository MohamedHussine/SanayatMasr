using System.ComponentModel.DataAnnotations;

public class CreateCraftsmanDTO
{
    [Required]
    public int UserId { get; set; }

    [Required]
    public int ProfessionId { get; set; }

    [Required, MinLength(10)]
    public string Bio { get; set; } = string.Empty;

    [Range(0, 50)]
    public int ExperienceYears { get; set; }

    [Range(0, 100000)]
    public decimal MinPrice { get; set; }

    [Range(0, 100000)]
    public decimal MaxPrice { get; set; }
}
