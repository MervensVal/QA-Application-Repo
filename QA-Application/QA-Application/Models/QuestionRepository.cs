using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QA_Application.Data;


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

        public IEnumerable<Question> ViewAllQuestions()
        {
            return _db.Question.ToList();
        }
    }
}
