using ForumApp.BusinessEntities;
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
    ///IPassword concrete class
    /// </summary>
    public class PasswordService : IPasswordService
    {
        private IUnitOfWork _unitOfWork;

        public PasswordService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
            var pass = _unitOfWork.PasswordRepository.Get(p => p.UserID == UserID && p.IsActive);
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