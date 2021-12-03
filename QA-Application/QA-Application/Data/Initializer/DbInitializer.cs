using Microsoft.AspNetCore.Identity;
using QA_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Data.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public void Initializer()
        {
            if (_db.Roles.Any(r => r.Name == "Admin")) 
            {
                return; //stops the function from continuing
            }

            //Create roles
            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin123@email.com",
                Email = "admin123@email.com",
                Name = "Merv"
            }, "Admin@123").GetAwaiter().GetResult();

            ApplicationUser user = _db.ApplicationUsers.Where(u => u.Email == "admin123@email.com").FirstOrDefault();
            _userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult();
        }
    }
}
