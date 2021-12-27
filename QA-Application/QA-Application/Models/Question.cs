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

        public int CategoryId { get; set; }

        [Display(Name = "Urgency Level")]
        public int UrgencyLevel { get; set; }

        public string Title { get; set; }

        [Display(Name = "Description")]
        public string QuestionBody { get; set; }

        public string Answer { get; set; }
    }
}

//Create Table Questions(
//QA_Id int primary key identity,
//UserId nvarchar(450) References AspNetUsers(Id) not null,
//CategoryId int References Category(CategoryId) not null,
//UrgencyLevel int not null,
//Title varchar(40) not null, 
//QuestionBody varchar(500) not null,
//Answer varchar(500),
//)