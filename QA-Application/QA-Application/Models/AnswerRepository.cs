using QA_Application.Data;
using QA_Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public class AnswerRepository : IAnswerRepository
    {
        readonly ApplicationDbContext _db;

        public AnswerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void addAnswer(Answer a)
        {
            _db.Answer.Add(a);
            _db.SaveChanges();
        }

        public Answer FindAnswerById(int id)
        {
            return (_db.Answer.FirstOrDefault(a => a.AnswerId == id));
        }

        public void Remove(Answer a)
        {
            _db.Answer.Remove(a);
            _db.SaveChanges();
        }

        public IEnumerable<ViewAnswerVM> viewAllAnswers(int id)
        {
                    var result = _db.Question.Join(
                    _db.Answer,
                    ques => ques.QA_Id,
                    ans => ans.QA_Id,
                    (ques, ans) => new ViewAnswerVM 
                {
                    QA_Id = ans.QA_Id,
                    AnswerId = ans.AnswerId,
                    UserName = ans.UserName,
                    Date = ans.Date,
                    AnswerBody = ans.AnswerBody,
                    Title = ques.Title,
                    QuestionBody = ques.QuestionBody
                }
            );
            var filteredResult = result.ToList().Where(a => a.QA_Id == id);
            return filteredResult;
        }

        public IEnumerable<Answer> AllAnswers() 
        {
            return _db.Answer.ToList();
        }
    }
}


