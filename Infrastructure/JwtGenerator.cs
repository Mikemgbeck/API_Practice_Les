using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Commander.Models;
using Microsoft.IdentityModel.Tokens;

namespace Commander.Infrastructure
{
    public class JwtGenerator : IJwtGenerator
    {
        public string CreateToken(ApplicationUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId, user.UserName),
                new Claim(ClaimTypes.Role, user.Role)
            };

            // generate signing credentials
            // these credentials allow our app to trust the tokens sent from the client
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SuperDuperUberUltraSecretKey"));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(10),
                SigningCredentials = credentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}