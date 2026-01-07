namespace ResumeBuilder.Core.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        // Navigation
        public ICollection<Resume> Resumes { get; set; } = new List<Resume>();
    }
}
