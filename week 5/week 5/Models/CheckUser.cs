using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace week_5.Models
{
    public class CheckUser
    {
        public int irFormId { get; set; }
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
        [Compare("MailRepeat")]
        [Display(Name = "Enter your email: ")]
        public string MailAddress { get; set; }

        [Display(Name = "Repeat your email: ")]
        public string MailRepeat { get; set; }

        [ValidateWebDate]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]//this is optional
        public DateTime dtBirth { get; set; }

        public class ValidateWebDate : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                DateTime birthday = (DateTime)value;
                if (birthday.Year < 1900)
                    return new ValidationResult("Surely you are not THAT old?");
                if (birthday.Year > 2000)
                    return new ValidationResult("Sorry, you're too young for this website!");
                if (birthday.Month == 12)
                    return new ValidationResult("Sorry, we don't accept anyone born in December!");
                return ValidationResult.Success;
            }
        }
    }
}
