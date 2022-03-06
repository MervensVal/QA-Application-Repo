using Microsoft.AspNetCore.Mvc;
using QA_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
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
    }
}
