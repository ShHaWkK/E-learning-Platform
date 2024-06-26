namespace E_Learning_Backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Submission> Submissions { get; set; } = new List<Submission>();
    }
}
