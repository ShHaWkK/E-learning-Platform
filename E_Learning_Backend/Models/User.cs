namespace E_Learning_Backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Student, Teacher, Admin

        // Navigation properties
        public ICollection<Course> Courses { get; set; } // Courses taught by the user if they are a teacher
        public ICollection<Submission> Submissions { get; set; }
    }
}
