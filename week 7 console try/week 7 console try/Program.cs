using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace week_7_console_try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting validation:");

            csWebUser user = new csWebUser();
            user.FirstName = null;
            user.LastName = "aa";
            user.MailAddress = "blah@blah@blah";

            var context = new ValidationContext(user, null, null);
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(user, context, results, true);

            if (!isValid)
            {
                Console.WriteLine("User is NOT valid! Errors:");
                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }
            Console.WriteLine("Done...");
            Console.ReadKey();
        }
    }

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
