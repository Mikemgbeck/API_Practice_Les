using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Commander.DTOs.ApplicationUserDTOs
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "The email entered is not in the correct format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}