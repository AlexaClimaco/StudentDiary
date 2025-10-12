using System.ComponentModel.DataAnnotations;

namespace StudentDiary.Infrastructure.Models
{
    public class Card
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string Rarity { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string CharacterName { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string? Description { get; set; }
        
        public int? AttackPower { get; set; }
        
        public int? DefensePower { get; set; }
        
        [StringLength(50)]
        public string? Element { get; set; }
        
        [StringLength(50)]
        public string? CardType { get; set; }
        
        public string? ImageUrl { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime? UpdatedAt { get; set; }
        
        // Foreign key to User
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;
    }
}