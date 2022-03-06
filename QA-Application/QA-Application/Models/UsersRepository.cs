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
            //var userRole = _dB.UserRoles.ToList();
            //var roles = _dB.Roles.ToList();

            //foreach (var user in userList) 
            //{
            //    var roleId = userRole.FirstOrDefault(u => u.UserId == user.Id).RoleId;
            //}

            return userList;

        }

        public void LockUnlockUsers()
        {
            throw new NotImplementedException();
        }
    }
}
