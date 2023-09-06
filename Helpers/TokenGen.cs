using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace server.Helpers
{
    public static class TokenGen
    {
        public static string GenerateToken(int id)
        {
            var mySecret = "It2is%my%secretSSSk3y66for^telegramAS4&^!SDapplication";
            var mySecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(mySecret));

            var myIssuer = "https://joydipkanjilal.com/";
            var myAudience = "https://joydipkanjilal.com/";

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, id.ToString()),
                }),
                Issuer = myIssuer,
                Expires = DateTime.UtcNow.AddYears(1),
                Audience = myAudience,
                SigningCredentials = new SigningCredentials(mySecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        public static async Task<bool> ValidateCurrentToken(string token)
        {
            var mySecret = "It2is%my%secretSSSk3y66for^telegramAS4&^!SDapplication";
            var mySecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(mySecret));

            var myIssuer = "https://joydipkanjilal.com/";
            var myAudience = "https://joydipkanjilal.com/";

            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                await tokenHandler.ValidateTokenAsync(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = myIssuer,
                    ValidAudience = myAudience,
                    IssuerSigningKey = mySecurityKey
                });
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
