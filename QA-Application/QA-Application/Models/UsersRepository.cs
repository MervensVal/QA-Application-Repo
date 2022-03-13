using Microsoft.EntityFrameworkCore;
using QA_Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationDbContext _dB;
        public UsersRepository(ApplicationDbContext dB) 
        {
            _dB = dB;
        }   
        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            var userList = _dB.ApplicationUser.ToList();
            return userList;
        }

        public ApplicationUser getUserbyId(string id)
        {
            var user = _dB.ApplicationUser.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public void LockUnlockUsers(ApplicationUser user)
        {
            if (user != null)
            {
                if (user.LockoutEnd != null && user.LockoutEnd > DateTime.Now)
                {
                    //user is locked so unlock user
                    user.LockoutEnd = DateTime.Now;
                }
                else
                {
                    //lock user for 1000 years
                    user.LockoutEnd = DateTime.Now.AddYears(1000);
                }
                _dB.Update(user);
                _dB.SaveChanges();
            }
        }
    }
}
