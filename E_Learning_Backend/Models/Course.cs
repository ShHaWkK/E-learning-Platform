namespace E_Learning_Backend.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
        public User Teacher { get; set; }

        // Navigation properties
        public ICollection<Module> Modules { get; set; }
        public ICollection<User> Students { get; set; }
    }
}
