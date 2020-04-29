using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace week_12_bootstrap.Controllers
{
    public class Week13Controller : Controller
    {
        public IActionResult Index()
        {
            return View("Week13");
        }
    }
}