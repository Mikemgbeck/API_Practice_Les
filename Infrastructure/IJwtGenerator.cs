using Commander.Models;

namespace Commander.Infrastructure
{
    public interface IJwtGenerator
    {
        string CreateToken(ApplicationUser user);
    }
}