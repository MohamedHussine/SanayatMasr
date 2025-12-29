namespace BusinessLogic.DTOs.Skills
{
    // DTO لعرض المهارات
    public class GetSkillDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
    }
}
