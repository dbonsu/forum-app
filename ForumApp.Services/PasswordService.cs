using ForumApp.BusinessEntities;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ForumApp.Services
{
    /// <summary>
    ///IPassword concrete class
    /// </summary>
    public class PasswordService : IPasswordService
    {
        public PasswordService()
        {
        }

        public IEnumerable<PasswordEntity> GetAllPasswords(long userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PasswordEntity> GetExpiredPasswords(long userID)
        {
            throw new NotImplementedException();
        }

        public string GetHash(string userName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// return the hashed password for comparison
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public string GetHash(long UserID)
        {
            //string hash = null;
            //var pass = .PasswordRepository.Get(p => p.UserID == UserID && p.IsActive);
            //if (pass != null)
            //{
            //    hash = pass.Hash;
            //}
            //return hash;
            return "";
        }

        public PasswordEntity GetPassword(long userID)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePassword(PasswordEntity password, long passwordID)
        {
            throw new NotImplementedException();
        }
    }
}