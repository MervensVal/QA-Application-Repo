using Microsoft.AspNetCore.Identity;
using QA_Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _Db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public DbInitializer(ApplicationDbContext Db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager) 
        {
            _Db = Db;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public void initialize()
        {
            //Create roles (similar code in register page)
            _roleManager.CreateAsync(new IdentityRole(Constants.RoleAdmin));
            _roleManager.CreateAsync(new IdentityRole(Constants.RoleEmplyee));
            _roleManager.CreateAsync(new IdentityRole(Constants.RoleGeneralUser));

            //Create admin user. Initialize properties and password
            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin123@email.com",
                Email = "admin123@email.com",
                Name = "Merv the Admin"
            }, "Admin@123").GetAwaiter().GetResult();

            //Find and give role to admin user
            ApplicationUser adminUser = _Db.ApplicationUser.Where(u => u.Email == "admin123@email.com").FirstOrDefault();
            _userManager.AddToRoleAsync(adminUser, Constants.RoleAdmin).GetAwaiter().GetResult();

        }
    }
}
