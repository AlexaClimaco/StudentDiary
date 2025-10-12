using StudentDiary.Services.DTOs;

namespace StudentDiary.Services.Interfaces
{
    public interface ICardService
    {
        // Create operations
        Task<CardDTO> CreateCardAsync(CreateCardDTO createCardDto, int userId);
        
        // Read operations
        Task<CardDTO?> GetCardByIdAsync(int cardId);
        Task<CardDTO?> GetCardByIdForUserAsync(int cardId, int userId);
        Task<IEnumerable<CardSummaryDTO>> GetAllCardsAsync();
        Task<IEnumerable<CardSummaryDTO>> GetCardsByUserIdAsync(int userId);
        Task<IEnumerable<CardSummaryDTO>> GetCardsByFilterAsync(CardFilterDTO filter);
        Task<IEnumerable<CardSummaryDTO>> GetCardsByFilterForUserAsync(CardFilterDTO filter, int userId);
        
        // Update operations
        Task<CardDTO?> UpdateCardAsync(UpdateCardDTO updateCardDto, int userId);
        
        // Delete operations
        Task<bool> DeleteCardAsync(int cardId, int userId);
        Task<bool> DeleteAllCardsForUserAsync(int userId);
        
        // Search operations
        Task<IEnumerable<CardSummaryDTO>> SearchCardsAsync(string searchTerm);
        Task<IEnumerable<CardSummaryDTO>> SearchCardsForUserAsync(string searchTerm, int userId);
        
        // Statistics
        Task<int> GetTotalCardsCountAsync();
        Task<int> GetUserCardsCountAsync(int userId);
        Task<IEnumerable<string>> GetAvailableRaritiesAsync();
        Task<IEnumerable<string>> GetAvailableElementsAsync();
        Task<IEnumerable<string>> GetAvailableCardTypesAsync();
        
        // Validation
        Task<bool> CardExistsAsync(int cardId);
        Task<bool> UserOwnsCardAsync(int cardId, int userId);
        Task<bool> CardNameExistsForUserAsync(string cardName, int userId, int? excludeCardId = null);
    }
}