using ForumApp.BusinessEntities;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services
{
    /// <summary>
    ///IPassword concrete class
    /// </summary>
    public class PasswordService : IPasswordService
    {
        public IEnumerable<PasswordEntity> GetAllPasswords(long userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PasswordEntity> GetExpiredPasswords(long userID)
        {
            throw new NotImplementedException();
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