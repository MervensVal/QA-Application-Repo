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
        public void addAnswer(Answer a); 
    }
}
