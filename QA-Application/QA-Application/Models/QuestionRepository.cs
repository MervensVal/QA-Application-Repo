using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QA_Application.Data;
using QA_Application.ViewModels;

namespace QA_Application.Models
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext _db;

        public QuestionRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void AddQuestion(Question q)
        {
            _db.Question.Add(q);
            _db.SaveChanges();
        }

        public void EditQuestion(Question q)
        {
            _db.Question.Update(q);
            //_db.Entry(q).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        public Question FindQuestionById(int id)
        {
            return (_db.Question.FirstOrDefault(q => q.QA_Id == id));
        }

        public void Remove(Question q)
        {
            _db.Question.Remove(q);
            _db.SaveChanges();
        }

        public IEnumerable<ViewQuestionVM> ViewAllQuestions()
        {
                var result = _db.Category.Join(
                    _db.Question,
                    cat => cat.CategoryId,
                    ques => ques.CategoryId,
                    (cat, ques) => new ViewQuestionVM
                        {
                            QA_Id = ques.QA_Id,
                            UserName = ques.UserName,
                            CategoryName = cat.CategoryName,
                            UrgencyLevel = ques.UrgencyLevel,
                            Title = ques.Title,
                            QuestionBody = ques.QuestionBody,
                        }
                    );
            return result.ToList();
        }
    }
}
