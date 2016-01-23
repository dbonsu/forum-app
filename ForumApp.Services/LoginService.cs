using ForumApp.Common.Utility;
using ForumApp.Services.Interfaces;
using System;

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
        private bool isAuthenticated = false;

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

        public bool IsAuthenticated
        {
            get
            {
                return this.isAuthenticated;
            }
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
            var userDTO = _userService.GetValidateUser(username);
            if (userDTO != null)
            {
                var correctHash = _passwordService.GetHash(userDTO.UserID);
                if (correctHash != null)
                {
                    return _passwordHash.ValidatePassword(password, correctHash);
                }
            }
            return false;
        }
    }
}