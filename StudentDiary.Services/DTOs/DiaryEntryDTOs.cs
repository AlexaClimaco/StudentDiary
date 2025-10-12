using System.ComponentModel.DataAnnotations;

namespace StudentDiary.Services.DTOs
{
    public class DiaryEntryCreateDto
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [StringLength(50)]
        public string Mood { get; set; } = string.Empty;

        [StringLength(500)]
        public string Tags { get; set; } = string.Empty;

        public bool IsPrivate { get; set; } = true;
    }

    public class DiaryEntryUpdateDto
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [StringLength(50)]
        public string Mood { get; set; } = string.Empty;

        [StringLength(500)]
        public string Tags { get; set; } = string.Empty;

        public bool IsPrivate { get; set; } = true;
    }

    public class DiaryEntryDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Mood { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;
        public bool IsPrivate { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
    }

    public class DiaryEntrySummaryDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Mood { get; set; } = string.Empty;
        public bool IsPrivate { get; set; }
        public string ContentPreview { get; set; } = string.Empty; // First 100 characters
    }

    public class DiaryEntrySearchDto
    {
        public string SearchTerm { get; set; } = string.Empty;
        public string Mood { get; set; } = string.Empty;
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? IsPrivate { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}