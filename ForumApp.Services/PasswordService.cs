using ForumApp.BusinessEntities;
using ForumApp.DataModel;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ForumApp.Services
{
    /// <summary>
    ///IPassword concrete class
    /// </summary>
    public class PasswordService : BaseService, IPasswordService
    {
        public PasswordService(ForumAppEntities context)
        {
            _context = new ForumAppEntities();
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
            string hash = null;
            var pass = _context.Passwords.Where(p => p.UserID == UserID && p.IsActive == true)
                .Select(p => new { p.Hash }).FirstOrDefault();
            if (pass != null)
            {
                hash = pass.Hash;
            }
            return hash;
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