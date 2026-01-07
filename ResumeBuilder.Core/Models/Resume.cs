namespace ResumeBuilder.Core.Models
{
    public class Resume
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        // Temporary photo path (Option A)
        public string? PhotoPath { get; set; }

        public int? JobTitleId { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        // Navigation
        public User User { get; set; } = null!;
        public JobTitle? JobTitle { get; set; }

        public ICollection<Education> Educations { get; set; } = new List<Education>();
        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
        public ICollection<Skill> Skills { get; set; } = new List<Skill>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();
        public ICollection<Certification> Certifications { get; set; } = new List<Certification>();
    }
}
