using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.Models
{
    public class UserModel
    {

        [Key]
        [Column("UserId", TypeName = "nvarchar(36)")]
        public string Id { get; set; }

        [Column("FirstName", TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Column("Email", TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Column("PasswordHash", TypeName = "varchar(300)")]
        public string PasswordHash { get; set; }

        [Required]
        [Phone]
        [Column("PhoneNumber", TypeName = "nvarchar(20)")]
        public string PhoneNumber { get; set; }

        [Column("Role", TypeName = "nvarchar(50)")]
        public UserRole Role { get; set; }

        [Required]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

        // Navigation property

        //User has one UserProfile
        public virtual UserProfileModel UserProfile { get; set; }
        public virtual ICollection<BookingModel> Bookings { get; set; }
        public virtual ICollection<ReviewModel> Reviews { get; set; }
        public virtual ICollection<NotificationModel> Notifications { get; set; }
    }

    public enum UserRole
    {
        Admin,
        SalonOwner,
        Customer
    }
}
