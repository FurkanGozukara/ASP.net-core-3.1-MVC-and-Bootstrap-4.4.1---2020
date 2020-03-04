using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace week_6.Models
{
    public class csWebUser
    {
        [Required]
        [StringLength(10)]
        [Display(Name = "Enter Your First Name:")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "geçerli olmayan bir eposta adresi girdiniz!")]
        public string MailAddress { get; set; }
    }
}
