using Microsoft.AspNetCore.Identity;

namespace Commander.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Role { get; set; }

        // default Role
        public ApplicationUser()
        {
            this.Role = "User";
        }
    }


}