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
        public IActionResult Index()
        {
            csWebUser myModel = new csWebUser { FirstName = "gg WP",MailAddress="gg@gmail.com" };
            return View("Index", myModel);
        }
        [HttpPost]
        public IActionResult Form1(csWebUser myModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View("Index");
        }

        public IActionResult Form2(csWebUser myModel)
        {
            if (ModelState.IsValid)
            {

            }
            myModel.FirstName = "Furkan";
            return View("Index", myModel);
        }
    }
}