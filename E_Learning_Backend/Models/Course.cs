namespace E_Learning_Backend.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int TeacherId { get; set; }
        public User Teacher { get; set; } = new User();
        public ICollection<Module> Modules { get; set; } = new List<Module>();
        public ICollection<User> Students { get; set; } = new List<User>();
        public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    }
}
