using BookingSystem.DTO.InternalDTO;
using BookingSystem.Interfaces.IServices;

namespace BookingSystem.Services
{
    public class ValidationService : IValidationService
    {
        public async Task<GeneralResponseInternalDTO> ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return new GeneralResponseInternalDTO(false, "Password must contain at least 8 characters");
            }
            return new GeneralResponseInternalDTO(true, "Password is valid");
        }

        public async Task<GeneralResponseInternalDTO> ValidateEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return new GeneralResponseInternalDTO(true, "Email is valid");
            }
            catch
            {
                return new GeneralResponseInternalDTO(false, "Email is not valid");
            }
        }
    }
}
