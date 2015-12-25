using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.Interfaces
{
    public interface IPasswordService
    {
        /// <summary>
        /// Creates a new password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        int CreatePassword(PasswordEntity password);

        /// <summary>
        /// Retrieves all passwords for a user
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<PasswordEntity> GetAllPasswords(long userID);

        /// <summary>
        /// Retrieved only expired passwords
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<PasswordEntity> GetExpiredPasswords(long userID);

        /// <summary>
        /// Retrieves a password
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        PasswordEntity GetPassword(long userID);

        /// <summary>
        /// Updates an existing password for an active user
        /// </summary>
        /// <param name="password"></param>
        /// <param name="passwordID"></param>
        /// <returns></returns>
        bool UpdatePassword(PasswordEntity password, long passwordID);
    }
}