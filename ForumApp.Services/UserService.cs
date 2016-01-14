using ForumApp.BusinessEntities;
using ForumApp.DataModel;
using ForumApp.DataModel.Repository.Interfaces;
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
        private IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

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
            IEnumerable<User> users = _unitOfWork.UserRepository.GetAll();
            IEnumerable<UserEntity> userEntities = AutoMapper.Mapper.Map<IEnumerable<UserEntity>>(users);
            return userEntities;
        }

        public UserEntity GetUserByID(long userID)
        {
            User user = null;
            if (userID != 0)
            {
                user = _unitOfWork.UserRepository.Get(u => u.ID == userID);
            }

            UserEntity userEnitity = AutoMapper.Mapper.Map<UserEntity>(user);
            return userEnitity;
        }

        public UserEntity GetUserByUsername(string username)
        {
            User user = null;
            if (username != null)
            {
                user = _unitOfWork.UserRepository.Get(u => u.Username == "derick");
            }

            UserEntity userEnitity = AutoMapper.Mapper.Map<UserEntity>(user);
            return userEnitity;
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