using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.ViewModels
{
    public class ViewQuestionVM
    {
        public int QA_Id { get; set; }
        public string UserName { get; set; }
        public string CategoryName { get; set; }
        public int UrgencyLevel { get; set; }
        public string Title { get; set; }
        public string QuestionBody { get; set; }
        public string Answer { get; set; }
    }
}
