using BookingSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.DTO
{
    public class UserRegisterRequestDTO
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public UserRole Role { get; set; }
    }
}
