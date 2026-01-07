namespace ResumeBuilder.Core.Models
{
    public class Education
    {
        public int Id { get; set; }

        public int ResumeId { get; set; }

        public string InstitutionName { get; set; } = null!;
        public string Degree { get; set; } = null!;
        public string? FieldOfStudy { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Navigation
        public Resume Resume { get; set; } = null!;
    }
}
