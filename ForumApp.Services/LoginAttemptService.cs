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
    /// ILoginAttemptService concrete class
    /// </summary>
    public class LoginAttemptService : ILoginAttemptService
    {
        public long CreateLoginAttempt(LoginAttemptEntity loginAttempt)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLoginAttempt(long id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLoginAttemptsByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginAttemptEntity> GetAllLoginAttempts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginAttemptEntity> GetAllLoginAttemptsByUserID(long userID)
        {
            throw new NotImplementedException();
        }
    }
}