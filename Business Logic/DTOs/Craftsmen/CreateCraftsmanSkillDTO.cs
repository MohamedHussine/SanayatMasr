
using System.ComponentModel.DataAnnotations;
using Shared.Helpers.Enums;

public class CreateCraftsmanSkillDTO
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "SkillId must be greater than 0")]
    public int SkillId { get; set; }

    [Required]
    [EnumDataType(typeof(ProficiencyLevel))]
    public ProficiencyLevel ProficiencyLevel { get; set; }
}
