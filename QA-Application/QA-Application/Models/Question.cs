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
        [MaxLength(100, ErrorMessage = "Title can only be up to 100 characters")]
        public string Title { get; set; }
        [Display(Name = "Description")]
        [MaxLength(8000, ErrorMessage = "Your question can only be up to 8000 characters")]
        public string QuestionBody { get; set; }
    }
}
