using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using week_5.Models;

namespace week_5.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View("Index");
        }

        [Route("SimpleBinding")]
        [HttpGet]
        public IActionResult SimpleBinding()
        {
            var webUser = new WebUser() { FirstName = "John", LastName = "Doe" };
            return View("Index", webUser);
        }

        [Route("SimpleBinding")]
        [HttpPost]
        public IActionResult SimpleBinding(WebUser webUser)
        {
            //TODO: Update in DB here...
            return Content($"User {webUser.FirstName} updated!");
        }
    }
}