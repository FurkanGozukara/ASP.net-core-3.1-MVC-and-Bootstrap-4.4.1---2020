using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace week_5.Models
{
    public class CheckUser
    {
        [Required(ErrorMessage = "bu alan boş bırakılamaz")]
        [StringLength(25)]

        [Display(Name = "Enter your first name: ")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Enter your last name: ")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Enter your email: ")]
        public string MailAddress { get; set; }
    }
}
