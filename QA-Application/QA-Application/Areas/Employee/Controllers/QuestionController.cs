using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QA_Application.Models;
using QA_Application.ViewModels;
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
        public static Question QuestionConst = null;
        private readonly IQuestionRepository _questionRepo;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAnswerRepository _answerRepo;

        public QuestionController(IQuestionRepository questionRepo, ICategoryRepository categoryRepository, IAnswerRepository answerRepo)
        {
            _questionRepo = questionRepo;
            _categoryRepository = categoryRepository;
            _answerRepo = answerRepo;
        }

        public IActionResult Index(int UrgencyLevel) 
        {
            if (UrgencyLevel != 0) 
            {
                return View(_questionRepo.ViewAllQuestions().Where(q => q.UrgencyLevel == UrgencyLevel).OrderBy(q => q.Date));
            }
            return View(_questionRepo.ViewAllQuestions());
        }
        public IActionResult AddQuestion()
        {
            AddQuestionVM addQuestionVM = new AddQuestionVM
            {
                Categories = _categoryRepository.viewAllCategories().Where(c => c.Archive == "No"),
            };
            return View(addQuestionVM);
        }

        public IActionResult MyQuestions()
        {
            return View(_questionRepo.MyQuestions(User.Identity.Name));
        }
   
        [HttpPost]
        public IActionResult AddQuestion(Question q)
        {
            if (ModelState.IsValid)
            {
                if (q.UserName is null)
                {
                    // will give the user's userId [q.UserName = User.FindFirstValue(ClaimTypes.NameIdentifier);]
                    q.UserName = User.Identity.Name;
                    DateTime currentDate = new DateTime();
                    currentDate = DateTime.Now;
                    q.Date = currentDate;
                }
                _questionRepo.AddQuestion(q);
                return (RedirectToAction("Index"));
            }
            AddQuestionVM addQuestionVM = new AddQuestionVM
            {
                Categories = _categoryRepository.viewAllCategories().Where(c => c.Archive == "No"),
            };
            return View(addQuestionVM);
        }



        public IActionResult Edit(int id)
        {
            //Using AddQuestionVM view model instead of creating a EditQuestionVM to save time. Reused the VM
            AddQuestionVM editQuestionVM = new AddQuestionVM
            {
                Categories = _categoryRepository.viewAllCategories().Where(c => c.Archive == "No"),
                Question = _questionRepo.FindQuestionById(id)
            };
            return View(editQuestionVM);
        }

        [HttpPost]
        public IActionResult Edit(Question q)
        {
            if (ModelState.IsValid)
            {
                _questionRepo.EditQuestion(q);
                return (RedirectToAction("Index"));
            }
            AddQuestionVM editQuestionVM = new AddQuestionVM
            {
                Categories = _categoryRepository.viewAllCategories().Where(c => c.Archive == "No"),
                Question = _questionRepo.FindQuestionById(q.QA_Id)
            };
            return View(editQuestionVM);
        }

        public IActionResult Delete(int id)
        {
            var quetionToDelete = _questionRepo.FindQuestionById(id);
            return View(quetionToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Question q)
        {
            var listOfAnswers = _answerRepo.AllAnswers().Where(a => a.QA_Id == q.QA_Id);
            foreach(var answer in listOfAnswers) 
            {
               _answerRepo.Remove(answer);
            }
            _questionRepo.Remove(q);
            return (RedirectToAction("Index"));
        }

        //Add answer associated with Question
        public IActionResult AddAnswer(int id)
        {
            QuestionConst = _questionRepo.FindQuestionById(id);
            AddAnswerVM addAnswerVM = new AddAnswerVM
            {
                Question = _questionRepo.FindQuestionById(id)
            };
            return View(addAnswerVM);
        }

        [HttpPost]
        public IActionResult AddAnswer(Answer a)
        {
            if (ModelState.IsValid)
            {
                if (a.UserName is null)
                {
                    // will give the user's userId <- q.UserName = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    a.UserName = User.Identity.Name;
                    a.Date = DateTime.Now;
                    a.QA_Id = QuestionConst.QA_Id;
                }
                _answerRepo.addAnswer(a);
                return (RedirectToAction("Index"));
            }
            AddAnswerVM addAnswerVM = new AddAnswerVM
            {
                Question = QuestionConst
            };
            return View(addAnswerVM);
        }

        // View all answer associated with a question
        public IActionResult ViewAnswers(int id)
        {
            //Method 2 but less effective for obtaining data from controller to view
            //ViewData["Question"] = _questionRepo.FindQuestionById(id).QuestionBody;
            var answers = _answerRepo.viewAllAnswers(id);
            return View(answers);
        }
    }
}
