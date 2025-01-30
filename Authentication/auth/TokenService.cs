using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Model_Entity.DTO;
using Model_Entity.Models;

namespace Authentication.auth
{
    public class TokenService : ITokenService
    {

        public string GenerateToken(User UserName)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, UserName.Email),
                new Claim(ClaimTypes.Role, UserName.Role.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };
            var creds = new SigningCredentials(JwtService.GetSigningKey(), SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "https://localhost:7039",
                audience: "https://localhost:7039",
                claims: claims,
                expires: DateTime.Now.AddDays(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

