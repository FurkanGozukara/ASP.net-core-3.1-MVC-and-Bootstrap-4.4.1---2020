using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace week_6.Controllers
{
    public class Week9Controller : Controller
    {
        [Route("Week9")]
        public IActionResult Index()
        {
            return View("Week9");
        }

        [Route("Week9/Error")]
        public IActionResult Error()
        {
            return Content(Convert.ToInt32("error").ToString());
        }
    }
}