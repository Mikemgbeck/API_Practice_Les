using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Commander.DTOs.ApplicationUserDTOs
{
    public class UserRegisterDTO
    {
        [Required(ErrorMessage = "User name is required")]
        [StringLength(20, ErrorMessage = "User name cannot be more than 20 characters long")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "The email entered is not in the correct format")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*#?&]{8,}$",
            ErrorMessage = "Password must be at least 8 characters long and must " +
                           "include at least 1 letter and 1 number")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "Password and confirm password do not match, please try again")]
        public string ConfirmPassword { get; set; }
    }
}