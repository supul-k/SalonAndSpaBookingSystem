using BookingSystem.DTO;
using BookingSystem.Interfaces.IRepositories;
using BookingSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;

        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [HttpGet("profile/{userId}", Name = "GetUserProfile")]
        public async Task<IActionResult> GetUserProfileByUserId(string userId)
        {
            try
            {
                var userProfile = await _userProfileService.GetUserProfileByUserId(userId);
                if (userProfile.Status)
                {
                    return Ok(userProfile);
                }

                return NotFound(userProfile);
            }
            catch (Exception ex)
            {
                var response = new GeneralResposnseDTO(false, ex.Message);
                return BadRequest(response);
            }
        }

        [HttpPut("update-profile", Name = "UpdateUserProfile")]
        public async Task<IActionResult> UpdateUserProfile(UserProfileUpdateRequestDTO request)
        {
            try
            {
                var userProfileResult = await _userProfileService.UserProfileExist(request.UserId);
                if (!userProfileResult.Status)
                {
                    return BadRequest(userProfileResult);
                }

                var existingUserProfile = userProfileResult.Data as UserProfileModel;

                if (!string.IsNullOrEmpty(request.Address)) existingUserProfile.Address = request.Address;
                if (!string.IsNullOrEmpty(request.City)) existingUserProfile.City = request.City;
                if (!string.IsNullOrEmpty(request.State)) existingUserProfile.State = request.State;
                if (!string.IsNullOrEmpty(request.ZipCode)) existingUserProfile.ZipCode = request.ZipCode;
                if (!string.IsNullOrEmpty(request.Country)) existingUserProfile.Country = request.Country;
                if (!string.IsNullOrEmpty(request.ProfilePictureUrl)) existingUserProfile.ProfilePictureUrl = request.ProfilePictureUrl;

                existingUserProfile.UpdatedAt = DateTime.UtcNow;

                var result = await _userProfileService.UpdateUserProfile(existingUserProfile);
                if (!result.Status)
                {
                    return BadRequest(result);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                var response = new GeneralResposnseDTO(false, ex.Message);
                return BadRequest(response);
            }
        }
    }
}
