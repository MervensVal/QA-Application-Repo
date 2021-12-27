using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.ViewModels
{
    public class ViewAnswerVM
    {
        public int AnswerId { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string AnswerBody { get; set; }
        public int QA_Id { get; set; }
        public string Title { get; set; }
        public string QuestionBody { get; set; }
    }
}
