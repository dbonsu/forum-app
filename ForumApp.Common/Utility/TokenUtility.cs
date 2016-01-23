using ForumApp.Common.StaticConfig;
using System;
using System.Configuration;
using System.IdentityModel.Tokens;
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

        public string GenerateToken(string userName, string roleName)
        {
            keyByteArray = Encoding.Default.GetBytes(symmetricKeyAsBase64);

            signingKey = new HmacSigningCredentials(keyByteArray);

            var issued = DateTime.UtcNow;

            var expires = DateTime.UtcNow.AddMinutes(20);
            var claims = new[]
            {
                new System.Security.Claims.Claim("role", roleName)
            };

            var token = new System.IdentityModel.Tokens.JwtSecurityToken(issuer, audienceId, claims, issued, expires, signingKey);

            var handler = new JwtSecurityTokenHandler();

            var jwt = handler.WriteToken(token);

            return jwt;
        }

        public bool ValidateToken(string token)
        {
            var validationParameters = new TokenValidationParameters()
            {
                ValidAudience = audienceId,
                IssuerSigningToken = new BinarySecretSecurityToken(keyByteArray),
                ValidIssuer = issuer
            };
            var handler = new JwtSecurityTokenHandler();
            SecurityToken t = null;
            handler.ValidateToken(token, validationParameters, out t);

            return true;
        }
    }
}

///