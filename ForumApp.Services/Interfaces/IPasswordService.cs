﻿using System.Collections.Generic;

namespace ForumApp.Services.Interfaces
{
    public interface IPasswordService
    {
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
        /// Gets only the hash in the password db by user id
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        string GetHash(long UserID);

        /// <summary>
        /// Gets only the hash in the password db by username
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        string GetHash(string userName);

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