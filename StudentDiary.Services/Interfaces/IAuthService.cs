using StudentDiary.Services.DTOs;

namespace StudentDiary.Services.Interfaces
{
    public interface IAuthService
    {
        /// <summary>
        /// Registers a new user
        /// </summary>
        /// <param name="registrationDto">User registration data</param>
        /// <returns>User DTO if successful, null if failed</returns>
        Task<UserDto?> RegisterAsync(UserRegistrationDto registrationDto);

        /// <summary>
        /// Authenticates a user
        /// </summary>
        /// <param name="loginDto">User login credentials</param>
        /// <returns>User DTO if successful, null if failed</returns>
        Task<UserDto?> LoginAsync(UserLoginDto loginDto);

        /// <summary>
        /// Logs out the current user
        /// </summary>
        /// <param name="userId">User ID to logout</param>
        /// <returns>True if successful</returns>
        Task<bool> LogoutAsync(int userId);

        /// <summary>
        /// Changes user password
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="changePasswordDto">Password change data</param>
        /// <returns>True if successful</returns>
        Task<bool> ChangePasswordAsync(int userId, ChangePasswordDto changePasswordDto);

        /// <summary>
        /// Updates user profile
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="updateDto">Profile update data</param>
        /// <returns>Updated User DTO if successful</returns>
        Task<UserDto?> UpdateProfileAsync(int userId, UserProfileUpdateDto updateDto);

        /// <summary>
        /// Gets user by ID
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>User DTO if found</returns>
        Task<UserDto?> GetUserByIdAsync(int userId);

        /// <summary>
        /// Validates if username is available
        /// </summary>
        /// <param name="username">Username to check</param>
        /// <returns>True if available</returns>
        Task<bool> IsUsernameAvailableAsync(string username);

        /// <summary>
        /// Validates if email is available
        /// </summary>
        /// <param name="email">Email to check</param>
        /// <returns>True if available</returns>
        Task<bool> IsEmailAvailableAsync(string email);

        /// <summary>
        /// Hashes a password
        /// </summary>
        /// <param name="password">Plain text password</param>
        /// <returns>Hashed password</returns>
        string HashPassword(string password);

        /// <summary>
        /// Verifies a password against hash
        /// </summary>
        /// <param name="password">Plain text password</param>
        /// <param name="hash">Hashed password</param>
        /// <returns>True if password matches</returns>
        bool VerifyPassword(string password, string hash);
    }
}