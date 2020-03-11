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

        public WebUser mySecondUser;

        public List<string> lstCountries { get; set; }

        [Display(Name = "Select User Language")]
        public int userLanguageId { get; set; }

        public csWebUser()
        {
            lstLanguages = new List<PerLanguage>
            {
                new PerLanguage
                {
                     Id=1,
                     Name="Turkish"
                },
                new PerLanguage
                {
                    Id=2,
                    Name="English"
                },
                new PerLanguage
                {
                    Id=3,
                    Name="Arabic"
                }
            };
        }

        public string userCountry { get; set; }

        public List<PerLanguage> lstLanguages;

        public class PerLanguage
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }


        public class WebUser
        {
            [Phone]
            public string PhoneNumber { get; set; }

            [EmailAddress]
            public string MailAddress2 { get; set; }

            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Date)]
            public DateTime Birthday { get; set; }

            public bool IsActive { get; set; }
        }
    }
}
