using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Data.ApplicationUserRepo;
using Commander.DataAccess;
using Commander.DTOs.ApplicationUserDTOs;
using Commander.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;

namespace Commander.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IApplicationUserRepository _applicationUserRepository;

        public AuthController(UserManager<ApplicationUser> userManager,
                              SignInManager<ApplicationUser> signInManager,
                              IApplicationUserRepository applicationUserRepository)
        {
            _signInManager = signInManager;
            _applicationUserRepository = applicationUserRepository;
            _userManager = userManager;
        }

        // [HttpGet]
        // public async Task<ApplicationUser> GetUsers()
        // {
        //     var user = await _userManager.FindByEmailAsync("bob@gmail.com");
        //     return user;
        // }

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

            // if successful send the object containing the token
            return result;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ApplicationUser>> Register(UserRegisterDTO userRegisterDTO)
        {
            var user = await _userManager.FindByEmailAsync(userRegisterDTO.Email);

            if (user != null)
            {
                return BadRequest("Email already in use");
            }

            ApplicationUser newUser = new ApplicationUser()
            {
                DisplayName = userRegisterDTO.UserName,
                UserName = userRegisterDTO.UserName,
                Email = userRegisterDTO.Email,
                LockoutEnabled = false
            };

            var result = await _userManager.CreateAsync(newUser, userRegisterDTO.Password);

            if (!result.Succeeded)
            {
                return BadRequest("Error creating new user");
            }

            return Ok(newUser);
        }
    }
}