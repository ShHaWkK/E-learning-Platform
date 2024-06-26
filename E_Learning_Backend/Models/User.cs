namespace E_Learning_Backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; } 
        public string? Email { get; set; } 
        public string? PasswordHash { get; set; } 
        public string? Role { get; set; } 
        public ICollection<Course>? Courses { get; set; }
        public ICollection<Submission>? Submissions { get; set; }
    }
}
