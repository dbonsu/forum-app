using ForumApp.Common.Utility;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services
{
    /// <summary>
    /// Public implementation of ILoginService
    /// </summary>
    public class LoginService : ILoginService
    {
        private IPasswordHash _passwordHash;
        private IPasswordService _passwordService;
        private IUserService _userService;

        /// <summary>
        /// public constructor
        /// </summary>
        /// <param name="passwordHash"></param>
        /// <param name="passwordService"></param>
        /// <param name="userService"></param>
        public LoginService(IPasswordHash passwordHash, IPasswordService passwordService, IUserService userService)
        {
            _passwordHash = passwordHash;
            _passwordService = passwordService;
            _userService = userService;
        }

        public void LogOut(long userID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true for an active and existing user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateUser(string username, string password)
        {
            var user = _userService.GetUserByUsername(username);
            if (user != null && user.IsActive)
            {
                var correctHash = _passwordService.GetHash(user.ID);
                return _passwordHash.ValidatePassword(password, correctHash);
            }
            return false;
        }
    }
}