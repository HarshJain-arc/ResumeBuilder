namespace ResumeBuilder.Core.Models
{
    public class Project
    {
        public int Id { get; set; }

        public int ResumeId { get; set; }

        public string ProjectName { get; set; } = null!;
        public string? Description { get; set; }
        public string? TechnologiesUsed { get; set; }

        // Navigation
        public Resume Resume { get; set; } = null!;
    }
}
