using BookingSystem.DTO.InternalDTO;
using BookingSystem.Models;

namespace BookingSystem.Interfaces.IRepositories
{
    public interface IUserProfileRepository
    {
        public Task<GeneralResponseInternalDTO> CreateUserProfile(UserProfileModel profile);
        public Task<GeneralResponseInternalDTO> GetUserProfileByUserId(string userId);

        public Task<GeneralResponseInternalDTO> UpdateUserProfile(UserProfileModel userProfile);

        public Task<GeneralResponseInternalDTO> UserProfileExist(string userId);
    }
}
