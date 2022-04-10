using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QA_Application.Models;
using QA_Application.Data;
using Microsoft.AspNetCore.Authorization;

namespace QA_Application.Areas.Admin.Controllers
{  
    [Area("admin")]
    [Authorize(Roles = Constants.RoleAdmin)]
    public class CategoryController : Controller
    {
        readonly ICategoryRepository _categoryRepo;

        public CategoryController(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public IActionResult Index()
        {
            return View(_categoryRepo.viewAllCategories().Where(c => c.Archive == "No"));
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.addCategory(c);
                return (RedirectToAction("Index"));
            }
            return View(c);
        }

        public IActionResult Archive(int id)
        {
            return View(_categoryRepo.getCategoryById(id));
        }

        [HttpPost]
        public IActionResult Archive(Category c)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.archive(c);
                return (RedirectToAction("Index"));
            }
            return View(c);
        }

        public IActionResult ArchiveList()
        {
            return View(_categoryRepo.viewAllCategories().Where(c => c.Archive == "Yes"));
        }
    }
}
