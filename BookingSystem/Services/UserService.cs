using BookingSystem.DTO.InternalDTO;
using BookingSystem.Interfaces.IRepositories;
using BookingSystem.Interfaces.IServices;
using BookingSystem.Models;

namespace BookingSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GeneralResponseInternalDTO> UserExist(string Email)
        {
            try
            {
                var result = await _userRepository.UserExist(Email);
                return result;
            }
            catch (Exception ex)
            {
                var response = new GeneralResponseInternalDTO(false, ex.Message);
                return response;
            }
        }

        public async Task<GeneralResponseInternalDTO> CreateUser(UserModel user)
        {
            try
            {
                var result = await _userRepository.CreateUser(user);
                return result;
            }
            catch (Exception ex)
            {
                var response = new GeneralResponseInternalDTO(false, ex.Message);
                return response;
            }
        }
    }
}
