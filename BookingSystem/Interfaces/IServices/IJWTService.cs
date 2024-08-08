using BookingSystem.DTO.InternalDTO;
using BookingSystem.Models;

namespace BookingSystem.Interfaces.IServices
{
    public interface IJWTService
    {
        public Task<GeneralResponseInternalDTO> GenerateJwtToken(UserModel userData);
    }
}
