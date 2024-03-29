﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public interface IUsersRepository
    {
        public IEnumerable<ApplicationUser> GetAllUsers();
        public void LockUnlockUsers(ApplicationUser user);
        public ApplicationUser getUserbyId(string id);

    }
}
