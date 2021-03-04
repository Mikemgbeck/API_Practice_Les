using System.Threading.Tasks;
using Commander.Data.ApplicationUserRepo;
using Commander.DTOs.ApplicationUserDTOs;
using Commander.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public AuthController(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }

        // ============== login endpoint ==============
        [HttpPost("login")]
        public async Task<ActionResult<UserResult>> Login(UserLoginDTO userLoginDTO)
        {
            // store the result from the repository
            var result = await _applicationUserRepository.Login(userLoginDTO);

            // if not successful, send the object in an UnAuthorized 401 response
            if (!result.Successful)
            {
                return Unauthorized(result);
            }

            Response.Cookies.Append("X-Commander-Token", result.Token, new CookieOptions() { HttpOnly = true, SameSite = SameSiteMode.Strict });

            // if successful send the object containing the token
            return Ok(result);
        }

        // ============== register endpoint ==============
        [HttpPost("register")]
        public async Task<ActionResult<UserResult>> Register(UserRegisterDTO userRegisterDTO)
        {
            var result = await _applicationUserRepository.Register(userRegisterDTO);

            if (!result.Successful)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        // ============== logout endpoint ==============
        [HttpPost("logout")]
        public ActionResult<UserResult> Logout()
        {
            Response.Cookies.Delete("X-Commander-Token");

            var result = new UserResult
            {
                Username = null,
                Email = null,
                Successful = true,
                Message = "User successfully logged out",
                Token = null
            };

            return Ok(result);
        }
    }
}