using BookingSystem.DTO.InternalDTO;
using BookingSystem.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;

namespace BookingSystem.Services
{
    public class HashPasswordService : IHashPasswordService
    {
        public async Task<GeneralResponseInternalDTO> HashPassword(string password)
        {
            try
            {
                var hashed = BCrypt.Net.BCrypt.HashPassword(password);

                var response = new GeneralResponseInternalDTO(true, hashed);
                return response;
            }
            catch (Exception ex)
            {
                var response = new GeneralResponseInternalDTO(false, ex.Message);
                return response;
            }
        }

        public async Task<GeneralResponseInternalDTO> VerifyPassword(string password, string PasswordHash)
        {
            bool verified = BCrypt.Net.BCrypt.Verify(password, PasswordHash);

            if (!verified)
            {
                return new GeneralResponseInternalDTO(verified, "Incorrect Password");
            }
            else
            {
                return new GeneralResponseInternalDTO(verified, "Password Verified");
            }
        }

    }
}
