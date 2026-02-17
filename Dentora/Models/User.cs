using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static Dentora.Common.Constants.ValidationConstants.UserConstants;

namespace Dentora.Models
{
    public class User
    {
        public User()
        {
            this.Appointments = new HashSet<Appointment>();
            this.UserRoles = new HashSet<UserRole>();
            this.Reviews = new HashSet<Review>();
        }
        [Key]
        public Guid Id { get; set; } 

        [Required]
        [MaxLength(NameMaxLength)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; } = null!;

        [MaxLength(100)]
        public string? FullName { get; set; }

        [MaxLength(20)]
        public string? Phone { get; set; }

        public int? Age { get; set; }

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string AvatarUrl { get; set; } = null!;

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
