using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDiary.Infrastructure.Models
{
    public class DiaryEntry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string Mood { get; set; } = string.Empty;

        [StringLength(500)]
        public string Tags { get; set; } = string.Empty;

        public bool IsPrivate { get; set; } = true;

        // Foreign key
        [Required]
        public int UserId { get; set; }

        // Navigation property
        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;
    }
}