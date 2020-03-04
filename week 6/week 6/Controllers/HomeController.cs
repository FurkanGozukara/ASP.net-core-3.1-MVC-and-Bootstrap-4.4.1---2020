using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using week_6.Models;

namespace week_6.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Index(csWebUser myModel)
        {
            if(ModelState.IsValid)
            {

            }

            return View("Index");
        }
    }
}