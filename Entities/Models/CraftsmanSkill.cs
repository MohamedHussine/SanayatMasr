using Shared.Helpers.Enums;

namespace Entities.Models

{
    public class CraftsmanSkill : BaseModel
    {
        public int CraftsmanId { get; set; }
        public Craftsman? Craftsman { get; set; }

        public int SkillId { get; set; }
        public Skill? Skill { get; set; }

        public ProficiencyLevel ProficiencyLevel { get; set; }
    }

}
