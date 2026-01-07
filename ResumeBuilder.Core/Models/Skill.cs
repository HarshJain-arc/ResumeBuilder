namespace ResumeBuilder.Core.Models
{
    public class Skill
    {
        public int Id { get; set; }

        public int ResumeId { get; set; }

        public string SkillName { get; set; } = null!;
        public int? ProficiencyLevel { get; set; } 

        // Navigation
        public Resume Resume { get; set; } = null!;
    }
}
