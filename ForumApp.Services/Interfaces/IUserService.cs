using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;

namespace ForumApp.Services.Interfaces
{
    /// <summary>
    /// Interface for handling all user db
    /// </summary>
    public interface IUserService : IDisposable
    {
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        long CreateUser(UserEntity user);

        /// <summary>
        /// Deletes a user
        /// </summary>
        /// <param name="userToDelete">user to delete</param>
        /// <param name="userAttemptinToDelete">Admin attempting to disable user</param>
        /// <returns></returns>
        bool DeleteUser(long userToDelete, long userAttemptinToDelete);

        /// <summary>
        /// Deactivates a user
        /// </summary>
        /// <param name="userToDisable">user to Disable</param>
        /// <param name="userAttemptingDeletion">Admin attempting to disable user</param>
        /// <returns></returns>
        bool DisableUser(long userToDisable, long userAttemptingToDisable);

        /// <summary>
        /// Retrieves all users
        /// </summary>
        /// <returns></returns>
        IEnumerable<UserEntity> GetAllUsers();

        /// <summary>
        /// Returns a user with few fields. Fieldsmay grow as needed
        ///
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        SimpleUserDTO GetSimpleUser(string username);

        /// <summary>
        /// Gets a user from db
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        UserEntity GetUserByID(long userID);

        /// <summary>
        /// Gets a user from db by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        UserEntity GetUserByUsername(string username);

        /// <summary>
        /// Gets a user profile from db
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        ProfileEntity GetUserProfileByUserID(long userID);

        /// <summary>
        /// retrieve a user with few properties
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        ValidateUserDTO GetValidateUser(string username);

        /// <summary>
        /// Updates a user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        bool UpdateUser(UserEntity user, long userID);
    }
}