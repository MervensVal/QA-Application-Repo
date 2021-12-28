using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public class Question
    {
        [Key]
        public int QA_Id { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Urgency Level")]
        public int UrgencyLevel { get; set; }
        public string Title { get; set; }
        [Display(Name = "Description")]
        public string QuestionBody { get; set; }
    }
}
