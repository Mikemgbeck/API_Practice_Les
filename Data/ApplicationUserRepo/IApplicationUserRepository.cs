using System.Threading.Tasks;
using Commander.DTOs.ApplicationUserDTOs;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Data.ApplicationUserRepo
{
    public interface IApplicationUserRepository
    {

        Task<UserResult> Login(UserLoginDTO userLoginDTO);
        Task<UserResult> Register(UserRegisterDTO userRegisterDTO);

    }
}