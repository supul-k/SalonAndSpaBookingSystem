using BookingSystem.DTO;
using BookingSystem.DTO.InternalDTO;
using BookingSystem.Interfaces.IServices;
using BookingSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace BookingSystem.Services
{
    public class HashPasswordService : IHashPasswordService
    {

        private readonly PasswordHasher<UserModel> _passwordHasher;

        public HashPasswordService(PasswordHasher<UserModel> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }
        public async Task<GeneralResponseInternalDTO> HashPassword(string password)
        {
            try
            {
                var user = new UserModel();
                var hashedPassword = _passwordHasher.HashPassword(user, password);

                var response = new GeneralResponseInternalDTO(true, "Password hashed successfully", hashedPassword);
                return response;
            }
            catch (Exception ex)
            {
                var response = new GeneralResponseInternalDTO(false, ex.Message);
                return response;
            }
        }

        //public async Task<GeneralResponseInternalDTO> VerifyPassword(UserModel user, string password)
        //{
        //    try
        //    {
        //        var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
        //
        //        var response = new GeneralResponseInternalDTO(result == PasswordVerificationResult.Success,
        //            result == PasswordVerificationResult.Success ? "Password is correct" : "Password is incorrect");
        //        return response;
        //    }
        //    catch (Exception ex)
        //    {
        //        var response = new GeneralResponseInternalDTO(false, ex.Message);
        //        return response;
        //    }
        //}

    }
}
