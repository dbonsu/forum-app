using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Common.Utility
{
    /// <summary>
    /// Interface for creating and decoding token
    /// </summary>
    public interface ITokenUtility
    {
        /// <summary>
        /// Generates token
        /// </summary>
        /// <returns></returns>
        string GenerateToken(string userName, string roleName);

        /// <summary>
        /// Validates a token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        bool ValidateToken(string token);
    }
}