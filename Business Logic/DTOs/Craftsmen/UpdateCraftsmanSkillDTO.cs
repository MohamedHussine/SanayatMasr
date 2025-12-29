using System.ComponentModel.DataAnnotations;
using Shared.Helpers.Enums;

public class UpdateCraftsmanSkillDTO 
{
    [Required]
    [EnumDataType(typeof(ProficiencyLevel))]
    public ProficiencyLevel ProficiencyLevel { get; set; }
}
