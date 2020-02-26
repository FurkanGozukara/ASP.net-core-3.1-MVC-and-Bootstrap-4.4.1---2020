using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace week_5.Controllers
{
    public class UsersController : Controller
    {
        [Route("Users")]
        [Route("Users/SimpleBinding")]
        public IActionResult Index()
        {
            return Content($"User updated!");
        }
    }
}