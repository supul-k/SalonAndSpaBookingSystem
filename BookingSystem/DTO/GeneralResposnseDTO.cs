using System.ComponentModel.DataAnnotations;

namespace BookingSystem.DTO
{
    public class GeneralResposnseDTO
    {
        [Required]
        public bool Status { get; set; }

        [Required]
        public string Message { get; set; }

        public GeneralResposnseDTO(bool status, string message)
        {
            this.Status = status;
            this.Message = message;
        }
    }
}
