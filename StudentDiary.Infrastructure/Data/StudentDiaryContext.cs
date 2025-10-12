using Microsoft.EntityFrameworkCore;
using StudentDiary.Infrastructure.Models;

namespace StudentDiary.Infrastructure.Data
{
    public class StudentDiaryContext : DbContext
    {
        public StudentDiaryContext(DbContextOptions<StudentDiaryContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User entity configuration
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.Username).IsUnique();
                entity.HasIndex(e => e.Email).IsUnique();
                
                entity.Property(e => e.Username).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(255);
                entity.Property(e => e.PasswordHash).IsRequired().HasMaxLength(255);
                entity.Property(e => e.FirstName).HasMaxLength(100);
                entity.Property(e => e.LastName).HasMaxLength(100);
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.IsActive).IsRequired();
            });

            // DiaryEntry entity configuration
            modelBuilder.Entity<DiaryEntry>(entity =>
            {
                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Title).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.Mood).HasMaxLength(50);
                entity.Property(e => e.Tags).HasMaxLength(500);
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
                entity.Property(e => e.IsPrivate).IsRequired();
                entity.Property(e => e.UserId).IsRequired();

                // Configure relationship
                entity.HasOne(d => d.User)
                    .WithMany(p => p.DiaryEntries)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}