namespace E_Learning_Backend.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public int EvaluationId { get; set; }
        public Evaluation? Evaluation { get; set; } 
        public int StudentId { get; set; }
        public User? Student { get; set; } 
        public double Grade { get; set; }
    }
}
