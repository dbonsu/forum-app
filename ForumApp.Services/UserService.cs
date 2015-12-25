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
    /// IUserService concrete class
    /// </summary>
    public class UserService : IUserService
    {
        public long CreateUser(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(long userToDelete, long userAttemptinToDelete)
        {
            throw new NotImplementedException();
        }

        public bool DisableUser(long userToDisable, long userAttemptingToDisable)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetUserByID(long userID)
        {
            throw new NotImplementedException();
        }

        public ProfileEntity GetUserProfileByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserEntity user, long userID)
        {
            throw new NotImplementedException();
        }
    }
}