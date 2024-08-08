using BookingSystem.DTO.InternalDTO;
using BookingSystem.Interfaces.IServices;

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

    }
}
