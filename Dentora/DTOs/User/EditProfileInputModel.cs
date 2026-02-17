using System;
using System.ComponentModel.DataAnnotations;

using static Dentora.Common.Constants.ValidationConstants.UserConstants;
using static Dentora.Common.Messages.ErrorMessages.UserMessages;

namespace Dentora.DTOs.User
{
    public class EditProfileInputModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = UsernameIsRequired)]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = PasswordIsRequired)]
        [MinLength(PasswordMinLength)]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; } = null!;

        public int? Age { get; set; }

        [Required(ErrorMessage = EmailIsRequired)]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = AvatarIsRequired)]
        public string AvatarUrl { get; set; } = null!;
    }
}
