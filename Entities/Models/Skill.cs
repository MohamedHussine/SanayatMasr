namespace Entities.Models
{
    public class Skill : BaseModel
    {
        public string Name { get; set; } = null!;
        public string ArabicName { get; set; } = null!;

        public virtual ICollection<CraftsmanSkill>? CraftsmanSkills { get; set; }
    }
}
