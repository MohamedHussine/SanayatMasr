

using Shared.Helpers.Enums;

public class CraftsmanSkillResponseDTO
{
    public int SkillId { get; set; }
    public string SkillName { get; set; } = null!;
    public ProficiencyLevel ProficiencyLevel { get; set; }
}
