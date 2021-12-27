using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int QA_Id { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string AnswerBody { get; set; }
    }
}
