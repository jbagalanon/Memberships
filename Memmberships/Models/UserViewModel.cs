﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memmberships.Models
{
    public class UserViewModel
    {

       
        [Display(Name ="User Id")]
        public string Id { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

   
        [Display(Name = "First Name ")]
        [StringLength(30, ErrorMessage ="The {0} must be at least {1} long", MinimumLength = 2)]
        public string  FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string Password { get; set; }
    }
}