using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "Category name can only be up to 40 characters")]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        [MaxLength(40, ErrorMessage = "Archive can only be up to 5 characters max")]
        public string Archive { get; set; }
    }
}

