using System.Collections.Generic;

namespace ForumApp.Services.Interfaces
{
    /// <summary>
    /// Interface for handling failed login attempts
    /// </summary>
    public interface ILoginAttemptService
    {
        /// <summary>
        /// Creates a new failed attemps
        /// </summary>
        /// <param name="loginAttempt"></param>
        /// <returns></returns>
        long CreateLoginAttempt(LoginAttemptEntity loginAttempt);

        /// <summary>
        /// Removes a login Attempt
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteLoginAttempt(long id);

        /// <summary>
        /// Removes a login attempt by userID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        bool DeleteLoginAttemptsByUserID(long userID);

        /// <summary>
        /// Retrieves all login attempts
        /// </summary>
        /// <returns></returns>
        IEnumerable<LoginAttemptEntity> GetAllLoginAttempts();

        /// <summary>
        /// Retrieves all LoginAttempts by userID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<LoginAttemptEntity> GetAllLoginAttemptsByUserID(long userID);
    }
}