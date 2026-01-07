namespace ResumeBuilder.Core.Models
{
    public class Certification
    {
        public int Id { get; set; }

        public int ResumeId { get; set; }

        public string Name { get; set; } = null!;
        public string? IssuedBy { get; set; }
        public DateTime? IssuedOn { get; set; }

        // Navigation
        public Resume Resume { get; set; } = null!;
    }
}
