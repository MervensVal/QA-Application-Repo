using QA_Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public interface IAnswerRepository
    {
        public IEnumerable<ViewAnswerVM> viewAllAnswers(int id);
        public IEnumerable<Answer> AllAnswers();
        public void addAnswer(Answer a); 
        public Answer FindAnswerById(int id);
        public void Remove(Answer a);
    }
}
