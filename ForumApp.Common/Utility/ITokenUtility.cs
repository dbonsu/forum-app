using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        /// Validates a token and returns a Principal
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        ClaimsPrincipal ValidateAndReadToken(string token);

        /// <summary>
        /// Validates a token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        bool ValidateToken(string token);
    }
}