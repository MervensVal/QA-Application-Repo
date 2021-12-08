using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public interface IQuestionRepository
    {
        public IEnumerable<Question> ViewAllQuestions();
        public void AddQuestion(Question q);
        public void EditQuestion(Question q);
        public Question FindQuestionById(int id);
        public void Remove(Question q);

    }
}
