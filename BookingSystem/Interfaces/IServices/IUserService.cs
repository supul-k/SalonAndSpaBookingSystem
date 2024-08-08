using BookingSystem.DTO.InternalDTO;
using BookingSystem.Models;

namespace BookingSystem.Interfaces.IServices
{
    public interface IUserService
    {
        public Task<GeneralResponseInternalDTO> UserExist(string Email);

        public Task<GeneralResponseInternalDTO> CreateUser(UserModel user);

        public Task<GeneralResponseInternalDTO> AuthenticateUser(string reqPassword, string PasswordHash);
    }
}
