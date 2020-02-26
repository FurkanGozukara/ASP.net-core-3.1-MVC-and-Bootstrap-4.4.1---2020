using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using week_5.Models;

namespace week_5.Controllers
{
    public class UserCheckController : Controller
    {
        [Route("UserCheck")]
        [Route("UserCheck2")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("UserCheck")]
        [HttpPost]
        public IActionResult SimpleValidation(CheckUser model, string hidden1)
        {
            if (ModelState.IsValid)
                return Content($"SimpleValidation 1 email {model.MailAddress}");
            else
                return View("Index",model);
        }

        [Route("UserCheck2")]
        [HttpPost]
        public IActionResult SimpleValidation2(CheckUser model, string hidden1)
        {
            if (ModelState.IsValid)
                return Content($"SimpleValidation 2 email {model.MailAddress}");
            else
                return View("Index", model);
        }
    }
}