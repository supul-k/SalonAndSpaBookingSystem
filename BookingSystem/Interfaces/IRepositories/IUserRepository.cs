using BookingSystem.DTO.InternalDTO;
using BookingSystem.Models;

namespace BookingSystem.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        public Task<GeneralResponseInternalDTO> UserExist(string Email);

        public Task<GeneralResponseInternalDTO> CreateUser(UserModel user);
    }
}
