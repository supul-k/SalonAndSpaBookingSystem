using BookingSystem.DTO;
using BookingSystem.Interfaces.IServices;
using BookingSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IValidationService _validationService;
        private readonly IUserService _userService;
        private readonly IHashPasswordService _hashPasswordService;

        public UserController(
            IValidationService validationService,
            IUserService userService,
            IHashPasswordService hashPasswordService
            ) 
        {
            _validationService = validationService;
            _userService = userService;
            _hashPasswordService = hashPasswordService;
        }

        [HttpPost("create-user", Name = "CreateUser")]
        public async Task<IActionResult> CreateUser(UserRegisterRequestDTO request)
        {
            try
            {
                var passwordValidation = await _validationService.ValidatePassword(request.Password);
                if (!passwordValidation.Status)
                {
                    return BadRequest(passwordValidation);
                }

                var emailValidation = await _validationService.ValidateEmail(request.Email);
                if (!emailValidation.Status)
                {
                    return BadRequest(emailValidation);
                }

                var userExist = await _userService.UserExist(request.Email);
                if (userExist.Status)
                {
                    var response = new GeneralResposnseDTO(userExist.Status, "Email already Exist!");
                    return BadRequest(response);
                }

                var hashedPasswordResponse = await _hashPasswordService.HashPassword(request.Password);
                if (!hashedPasswordResponse.Status)
                {
                    var response = new GeneralResposnseDTO(hashedPasswordResponse.Status, "Failed to hash password");
                    return BadRequest(response);
                }

                var hashedPassword = hashedPasswordResponse.Message;

                UserModel user = new UserModel();

                user.Id = Guid.NewGuid().ToString();
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.Email = request.Email;
                user.PasswordHash = hashedPassword;
                user.PhoneNumber = request.PhoneNumber;
                user.Role = request.Role;
                var result = await _userService.CreateUser(user);

                return result.Status ? Created("User Created Successfully", result) : BadRequest(result);
            }
            catch (Exception ex)
            {
                GeneralResposnseDTO rsponse = new GeneralResposnseDTO(false, ex.Message);
                return BadRequest(rsponse);
            }
        }
    }
}
