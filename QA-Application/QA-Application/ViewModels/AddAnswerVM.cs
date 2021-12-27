using QA_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.ViewModels
{
    public class AddAnswerVM
    {
        public Question Question { get; set; }
        public Answer Answer { get; set; } 
    }
}
