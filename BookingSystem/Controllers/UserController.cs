using BookingSystem.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController() { }

        [HttpPost("add-user", Name = "AddUser")]
        public async Task<IActionResult> AddUser(UserRegisterRequestDTO request)
        {
            try
            {

            }
            catch (Exception ex)
            {
                GeneralResposnseDTO rsponse = new GeneralResposnseDTO(false, ex.Message);
                return BadRequest(rsponse);
            }
        }
    }
}
