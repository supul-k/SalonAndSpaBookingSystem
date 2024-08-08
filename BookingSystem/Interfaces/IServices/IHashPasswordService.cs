using BookingSystem.DTO.InternalDTO;

namespace BookingSystem.Interfaces.IServices
{
    public interface IHashPasswordService
    {
        public Task<GeneralResponseInternalDTO> HashPassword(string password);

        public Task<GeneralResponseInternalDTO> VerifyPassword(string password, string PasswordHash);
    }
}
