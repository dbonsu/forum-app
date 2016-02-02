using ForumApp.Common.StaticConfig;
using System;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using System.ServiceModel.Security.Tokens;
using System.Text;
using Thinktecture.IdentityModel.Tokens;

namespace ForumApp.Common.Utility
{
    public class TokenUtility : ITokenUtility
    {
        private string audienceId = ConfigurationManager.AppSettings["audienceID"];
        private string issuer = "self";
        private byte[] keyByteArray;
        private HmacSigningCredentials signingKey;
        private string symmetricKeyAsBase64 = ConfigurationManager.AppSettings["SymmetricKey"];

        public TokenUtility()
        {
            keyByteArray = Encoding.Default.GetBytes(symmetricKeyAsBase64);

            signingKey = new HmacSigningCredentials(keyByteArray);
        }

        /// <summary>
        /// Generates a token given username and role
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public string GenerateToken(string userName, string roleName)
        {
            var issued = DateTime.UtcNow;

            var expires = DateTime.UtcNow.AddHours(5);
            var claims = new[]
            {
                new Claim("role", roleName),
                new Claim("user", userName)
            };

            var token = new System.IdentityModel.Tokens.JwtSecurityToken(issuer, audienceId, claims, issued, expires, signingKey);

            var handler = new JwtSecurityTokenHandler();

            var jwt = handler.WriteToken(token);

            return jwt;
        }

        /// <summary>
        /// Validates a token and returns a Principal
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public ClaimsPrincipal ValidateAndReadToken(string token)
        {
            var validationParameters = new TokenValidationParameters()
            {
                ValidAudience = audienceId,
                IssuerSigningToken = new BinarySecretSecurityToken(keyByteArray),
                ValidIssuer = issuer,
            };
            var handler = new JwtSecurityTokenHandler();
            SecurityToken securityToken = null;
            ClaimsPrincipal claimP = handler.ValidateToken(token, validationParameters, out securityToken);
            return DateTime.Compare(DateTime.UtcNow, securityToken.ValidTo) < 0 ? claimP : null;
        }

        /// <summary>
        /// Validates a token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool ValidateToken(string token)
        {
            var validationParameters = new TokenValidationParameters()
            {
                ValidAudience = audienceId,
                IssuerSigningToken = new BinarySecretSecurityToken(keyByteArray),
                ValidIssuer = issuer,
            };
            var handler = new JwtSecurityTokenHandler();
            SecurityToken securityToken = null;
            handler.ValidateToken(token, validationParameters, out securityToken);

            var result = DateTime.Compare(DateTime.UtcNow, securityToken.ValidTo);
            return result < 0;
        }
    }
}