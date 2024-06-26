using E_Learning_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Learning_Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relationships and constraints

            // User and Course (Teacher)
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId);

            // Course and Module
            modelBuilder.Entity<Module>()
                .HasOne(m => m.Course)
                .WithMany(c => c.Modules)
                .HasForeignKey(m => m.CourseId);

            // Module and Lesson
            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Module)
                .WithMany(m => m.Lessons)
                .HasForeignKey(l => l.ModuleId);

            // Course and Evaluation
            modelBuilder.Entity<Evaluation>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Evaluations)
                .HasForeignKey(e => e.CourseId);

            // Evaluation and Submission
            modelBuilder.Entity<Submission>()
                .HasOne(s => s.Evaluation)
                .WithMany(e => e.Submissions)
                .HasForeignKey(s => s.EvaluationId);

            // User and Submission (Student)
            modelBuilder.Entity<Submission>()
                .HasOne(s => s.Student)
                .WithMany(u => u.Submissions)
                .HasForeignKey(s => s.StudentId);

            // Message relationships
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            // Notification relationships
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany()
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
