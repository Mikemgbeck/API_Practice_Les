using System;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Commander.DTOs.ApplicationUserDTOs;
using Commander.Infrastructure;
using Commander.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Data.ApplicationUserRepo
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IJwtGenerator _jwtGenerator;

        public ApplicationUserRepository(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IJwtGenerator jwtGenerator)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<UserResult> Login(UserLoginDTO userLoginDTO)
        {
            var user = await _userManager.FindByEmailAsync(userLoginDTO.Email);

            if (user == null)
            {
                return new UserResult
                {
                    Username = null,
                    Email = null,
                    Successful = false,
                    Message = "User does not exist",
                    Token = null
                };
            }

            var results = await _signInManager.CheckPasswordSignInAsync(
                user, userLoginDTO.Password, false
                );

            if (results.Succeeded)
            {
                return new UserResult
                {
                    Username = user.UserName,
                    Email = user.Email,
                    Successful = true,
                    Message = "Login successful",
                    Token = _jwtGenerator.CreateToken(user)
                };
            }

            return new UserResult
            {
                Username = null,
                Email = null,
                Successful = false,
                Message = "Login failed",
                Token = null
            };
        }

        public async Task<UserResult> Register(UserRegisterDTO userRegisterDTO)
        {
            var user = await _userManager.FindByEmailAsync(userRegisterDTO.Email);

            if (user != null)
            {
                return new UserResult
                {
                    Username = null,
                    Email = null,
                    Successful = false,
                    Message = "Email already in use, please try a different one",
                    Token = null
                };
            }

            var userByName = await _userManager.FindByNameAsync(userRegisterDTO.UserName);

            if (userByName != null)
            {
                return new UserResult
                {
                    Username = null,
                    Email = null,
                    Successful = false,
                    Message = "Username already in use, please try a different one",
                    Token = null
                };
            }

            ApplicationUser newUser = new ApplicationUser()
            {
                UserName = userRegisterDTO.UserName,
                Email = userRegisterDTO.Email,
                LockoutEnabled = false
            };

            var result = await _userManager.CreateAsync(newUser, userRegisterDTO.Password);

            if (!result.Succeeded)
            {
                return new UserResult
                {
                    Username = null,
                    Email = null,
                    Successful = false,
                    Message = $"Error creating new user: {result.Errors.ToString()}",
                    Token = null
                };
            }

            return new UserResult
            {
                Username = newUser.UserName,
                Email = newUser.Email,
                Successful = true,
                Message = "User created successfully",
                Token = null
            };
        }

    }
}