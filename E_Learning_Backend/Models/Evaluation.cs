namespace E_Learning_Backend.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
        public string? Title { get; set; } 
        public string? Description { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; } 
        public ICollection<Submission>? Submissions { get; set; } 
    }
}
