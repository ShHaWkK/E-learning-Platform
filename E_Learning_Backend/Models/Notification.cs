namespace E_Learning_Backend.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string? Content { get; set; } 
        public int UserId { get; set; }
        public User? User { get; set; } 
        public DateTime Timestamp { get; set; }
        public bool IsRead { get; set; }
    }
}
