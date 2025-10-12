using System.ComponentModel.DataAnnotations;

namespace StudentDiary.Services.DTOs
{
    public class CreateCardDTO
    {
        [Required]
        [StringLength(100, ErrorMessage = "Card name cannot exceed 100 characters.")]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50, ErrorMessage = "Rarity cannot exceed 50 characters.")]
        public string Rarity { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100, ErrorMessage = "Character name cannot exceed 100 characters.")]
        public string CharacterName { get; set; } = string.Empty;
        
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }
        
        [Range(0, int.MaxValue, ErrorMessage = "Attack power must be a positive number.")]
        public int? AttackPower { get; set; }
        
        [Range(0, int.MaxValue, ErrorMessage = "Defense power must be a positive number.")]
        public int? DefensePower { get; set; }
        
        [StringLength(50, ErrorMessage = "Element cannot exceed 50 characters.")]
        public string? Element { get; set; }
        
        [StringLength(50, ErrorMessage = "Card type cannot exceed 50 characters.")]
        public string? CardType { get; set; }
        
        public string? ImageUrl { get; set; }
    }

    public class UpdateCardDTO
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100, ErrorMessage = "Card name cannot exceed 100 characters.")]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50, ErrorMessage = "Rarity cannot exceed 50 characters.")]
        public string Rarity { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100, ErrorMessage = "Character name cannot exceed 100 characters.")]
        public string CharacterName { get; set; } = string.Empty;
        
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }
        
        [Range(0, int.MaxValue, ErrorMessage = "Attack power must be a positive number.")]
        public int? AttackPower { get; set; }
        
        [Range(0, int.MaxValue, ErrorMessage = "Defense power must be a positive number.")]
        public int? DefensePower { get; set; }
        
        [StringLength(50, ErrorMessage = "Element cannot exceed 50 characters.")]
        public string? Element { get; set; }
        
        [StringLength(50, ErrorMessage = "Card type cannot exceed 50 characters.")]
        public string? CardType { get; set; }
        
        public string? ImageUrl { get; set; }
    }

    public class CardDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Rarity { get; set; } = string.Empty;
        public string CharacterName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? AttackPower { get; set; }
        public int? DefensePower { get; set; }
        public string? Element { get; set; }
        public string? CardType { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
    }

    public class CardSummaryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Rarity { get; set; } = string.Empty;
        public string CharacterName { get; set; } = string.Empty;
        public int? AttackPower { get; set; }
        public int? DefensePower { get; set; }
        public string? Element { get; set; }
        public string? CardType { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CardFilterDTO
    {
        public string? Name { get; set; }
        public string? Rarity { get; set; }
        public string? Element { get; set; }
        public string? CardType { get; set; }
        public int? MinAttackPower { get; set; }
        public int? MaxAttackPower { get; set; }
        public int? MinDefensePower { get; set; }
        public int? MaxDefensePower { get; set; }
        public DateTime? CreatedAfter { get; set; }
        public DateTime? CreatedBefore { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}