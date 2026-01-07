namespace ResumeBuilder.Core.Models
{
    public class Experience
    {
        public int Id { get; set; }

        public int ResumeId { get; set; }

        public string CompanyName { get; set; } = null!;
        public string JobTitle { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string? Responsibilities { get; set; }

        // Navigation
        public Resume Resume { get; set; } = null!;
    }
}
