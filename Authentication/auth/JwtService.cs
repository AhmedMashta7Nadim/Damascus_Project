using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Authentication.auth
{
    public static class JwtService
    {
        private const string Key = "77777777777777777777777777777777";

        public static TokenValidationParameters GetValidationParameters()
        {
            return new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "https://localhost:7039",
                ValidAudience = "https://localhost:7039",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key))
            };
        }
        public static SymmetricSecurityKey GetSigningKey()
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
        }


    }
}
