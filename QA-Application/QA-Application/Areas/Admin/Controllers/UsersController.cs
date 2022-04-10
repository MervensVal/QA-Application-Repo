using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QA_Application.Models;
using QA_Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Constants.RoleAdmin)]
    public class UsersController : Controller
    {
        private readonly IUsersRepository _userRepo;

        public UsersController(IUsersRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public IActionResult Index()
        {
            return View(_userRepo.GetAllUsers());
        }

        public IActionResult LockandUnlock(string id)
        {
            ApplicationUser user = _userRepo.getUserbyId(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult LockandUnlock(ApplicationUser user) 
        {
            if (ModelState.IsValid) 
            {
                _userRepo.LockUnlockUsers(user);
                return (RedirectToAction("Index"));
            }
            return View(user);
        }
    }
}
