using System.Collections.Generic;
using Commander.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Commander.DataAccess
{
    // adding the type of <ApplicationUser> here means we don't need to add a DbSet for it
    public class CommanderContext : IdentityDbContext<ApplicationUser>
    {
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)
        {

        }

        public DbSet<Command> Commands { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // var hasher = new PasswordHasher<IdentityUser>();
            //
            // builder.Entity<ApplicationUser>().HasData(
            // new List<ApplicationUser>
            // {
            //     new ApplicationUser
            //     {
            //         DisplayName = "BobTheSavage",
            //         UserName = "bob",
            //         Email = "bob@gmail.com",
            //         PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
            //     },
            //     new ApplicationUser
            //     {
            //         DisplayName = "AndyTheKind",
            //         UserName = "andy",
            //         Email = "andy@gmail.com",
            //         PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
            //     },
            //     new ApplicationUser
            //     {
            //         DisplayName = "GeorgeTheWise",
            //         UserName = "george",
            //         Email = "georige@gmail.com",
            //         PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
            //     }
            // });
        }
    }
}