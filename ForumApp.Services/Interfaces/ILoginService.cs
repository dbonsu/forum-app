using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.Interfaces
{
    /// <summary>
    /// Interface for handling login and logout functionalities
    /// </summary>
    public interface ILoginService
    {
        /// <summary>
        /// Removes a user's current activity
        /// </summary>
        /// <param name="userID"></param>
        void LogOut(long userID);

        /// <summary>
        ///Returns true for a valid user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool ValidateUser(string username, string password);
    }
}