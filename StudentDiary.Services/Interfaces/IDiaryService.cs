using StudentDiary.Services.DTOs;

namespace StudentDiary.Services.Interfaces
{
    public interface IDiaryService
    {
        /// <summary>
        /// Creates a new diary entry
        /// </summary>
        /// <param name="userId">User ID who owns the entry</param>
        /// <param name="createDto">Diary entry data</param>
        /// <returns>Created diary entry DTO</returns>
        Task<DiaryEntryDto?> CreateEntryAsync(int userId, DiaryEntryCreateDto createDto);

        /// <summary>
        /// Updates an existing diary entry
        /// </summary>
        /// <param name="userId">User ID who owns the entry</param>
        /// <param name="entryId">Entry ID to update</param>
        /// <param name="updateDto">Updated diary entry data</param>
        /// <returns>Updated diary entry DTO</returns>
        Task<DiaryEntryDto?> UpdateEntryAsync(int userId, int entryId, DiaryEntryUpdateDto updateDto);

        /// <summary>
        /// Deletes a diary entry
        /// </summary>
        /// <param name="userId">User ID who owns the entry</param>
        /// <param name="entryId">Entry ID to delete</param>
        /// <returns>True if successful</returns>
        Task<bool> DeleteEntryAsync(int userId, int entryId);

        /// <summary>
        /// Gets a diary entry by ID
        /// </summary>
        /// <param name="userId">User ID who owns the entry</param>
        /// <param name="entryId">Entry ID to retrieve</param>
        /// <returns>Diary entry DTO if found</returns>
        Task<DiaryEntryDto?> GetEntryByIdAsync(int userId, int entryId);

        /// <summary>
        /// Gets all diary entries for a user
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number for pagination</param>
        /// <param name="pageSize">Page size for pagination</param>
        /// <returns>List of diary entry summaries</returns>
        Task<IEnumerable<DiaryEntrySummaryDto>> GetUserEntriesAsync(int userId, int pageNumber = 1, int pageSize = 10);

        /// <summary>
        /// Searches diary entries for a user
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="searchDto">Search parameters</param>
        /// <returns>List of matching diary entry summaries</returns>
        Task<IEnumerable<DiaryEntrySummaryDto>> SearchEntriesAsync(int userId, DiaryEntrySearchDto searchDto);

        /// <summary>
        /// Gets entries by mood for a user
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="mood">Mood to filter by</param>
        /// <returns>List of diary entry summaries</returns>
        Task<IEnumerable<DiaryEntrySummaryDto>> GetEntriesByMoodAsync(int userId, string mood);

        /// <summary>
        /// Gets entries within a date range for a user
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="fromDate">Start date</param>
        /// <param name="toDate">End date</param>
        /// <returns>List of diary entry summaries</returns>
        Task<IEnumerable<DiaryEntrySummaryDto>> GetEntriesByDateRangeAsync(int userId, DateTime fromDate, DateTime toDate);

        /// <summary>
        /// Gets the total count of entries for a user
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Total entry count</returns>
        Task<int> GetUserEntryCountAsync(int userId);

        /// <summary>
        /// Gets recent entries for a user
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="count">Number of recent entries to retrieve</param>
        /// <returns>List of recent diary entry summaries</returns>
        Task<IEnumerable<DiaryEntrySummaryDto>> GetRecentEntriesAsync(int userId, int count = 5);

        /// <summary>
        /// Gets mood statistics for a user
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Dictionary with mood counts</returns>
        Task<Dictionary<string, int>> GetMoodStatisticsAsync(int userId);
    }
}