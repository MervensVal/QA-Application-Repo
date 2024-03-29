﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        [NotMapped]
        public string Role { get; set; }

    }
}
