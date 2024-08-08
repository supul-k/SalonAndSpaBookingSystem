using BookingSystem.DTO.InternalDTO;
using BookingSystem.Interfaces.IServices;
using BookingSystem.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookingSystem.Services
{
    public class JWTService : IJWTService
    {
        private readonly IConfiguration _configuration;

        public JWTService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<GeneralResponseInternalDTO> GenerateJwtToken(UserModel userData)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Issuer = _configuration["Jwt:Issuer"],
                    Subject = new ClaimsIdentity(new[] {
                        new Claim("id", userData.Id),
                        new Claim("email", userData.Email),
                        new Claim("role", userData.Role.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var JWTToken = tokenHandler.WriteToken(token);

                var response = new GeneralResponseInternalDTO(true, "Token created Successfully", JWTToken);
                return response;
            }   
            catch (Exception ex)
            {
                var response = new GeneralResponseInternalDTO(false, ex.Message);
                return response;
            }
        }
    }
}
