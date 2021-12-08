using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QA_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QA_Application.Areas.Employee
{
    [Area("employee")]
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepo;

        public QuestionController(IQuestionRepository questionRepo)
        {
            _questionRepo = questionRepo;
        }

        public IActionResult Index()
        {
            ViewData["UserEmail"] = User.FindFirstValue(ClaimTypes.Email);
            return View(_questionRepo.ViewAllQuestions());
        }

        public IActionResult AddQuestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddQuestion(Question q)
        {
            if (ModelState.IsValid)
            {
                if (q.UserName is null)
                {
                    // will give the user's userId
                    //q.UserName = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    q.UserName = User.Identity.Name;
                }
                _questionRepo.AddQuestion(q);
                return (RedirectToAction("Index"));
            }
            return View(q);
        }

        public IActionResult Answer(int id) 
        {
            return View(_questionRepo.FindQuestionById(id));
        }

        [HttpPost]
        public IActionResult Answer(Question q)
        {
            if (ModelState.IsValid) 
            {
                _questionRepo.EditQuestion(q);
                return (RedirectToAction("Index"));
            }
            return View(q);
        }

        public IActionResult Edit(int id)
        {
            return View(_questionRepo.FindQuestionById(id));
        }

        [HttpPost]
        public IActionResult Edit(Question q)
        {
            if (ModelState.IsValid)
            {
                _questionRepo.EditQuestion(q);
                return (RedirectToAction("Index"));
            }
            return View(q);
        }

        public IActionResult Delete(int id)
        {
            var quetionToDelete = _questionRepo.FindQuestionById(id);
            return View(quetionToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Question q)
        {
            _questionRepo.Remove(q);
            return (RedirectToAction("Index"));
        }
    }
}
