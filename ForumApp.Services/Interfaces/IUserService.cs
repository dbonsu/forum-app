using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.Interfaces
{
    /// <summary>
    /// Interface for handling all user db
    /// </summary>
    public interface IUserService
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
        /// Gets a user from db
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        UserEntity GetUserByID(long userID);

        /// <summary>
        /// Updates a user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        bool UpdateUser(UserEntity user, long userID);
    }
}