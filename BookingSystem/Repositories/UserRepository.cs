using BookingSystem.DatabaseAccess;
using BookingSystem.DTO.InternalDTO;
using BookingSystem.Interfaces.IRepositories;
using BookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<GeneralResponseInternalDTO> UserExist(string Email)
        {
            try
            {
                var existingUser =  await _context.Users.FirstOrDefaultAsync(u => u.Email == Email);
                await _context.SaveChangesAsync();
                var response = new GeneralResponseInternalDTO(true, "User Found", existingUser);
                return response;

            }
            catch (Exception ex)
            {
                GeneralResponseInternalDTO response =  new GeneralResponseInternalDTO(false, ex.Message);
                return response;
            }
        }

        public async Task<GeneralResponseInternalDTO> CreateUser(UserModel user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                var response = new GeneralResponseInternalDTO(true, "User created successfully");
                return response;
            }
            catch (Exception ex)
            {
                var response = new GeneralResponseInternalDTO(false, ex.Message);
                return response;
            }
        }
    }
}
