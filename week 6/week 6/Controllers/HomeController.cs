using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            var userId = HttpContext.Request.Cookies["user_id"];
            var not_exists = HttpContext.Request.Cookies["not_exists"];
            var persistent_cookie = HttpContext.Request.Cookies["this_is_a_long_cookie"];
            var path_cookie = HttpContext.Request.Cookies["path_cookie"];

            csWebUser myModel = new csWebUser { FirstName = "gg WP",MailAddress="gg@gmail.com",
            mySecondUser = new csWebUser.WebUser {
             Birthday=new DateTime(1997,3,12),
              IsActive=true,
               MailAddress2="example@gmail.com",
                Password="fdgdfgfd",
                 PhoneNumber="5872223598"
            }
            };
            myModel.userCountry = "Germany";
            myModel.lstCountries = new List<string>
            {
                "Turkey",
                "United States",
                "Greece",
                "Germany"
           };

            HttpContext.Session.SetString("date", DateTime.Now.ToString());

          
            return View("Index", myModel);
        }
        [HttpPost]
        public IActionResult Form1(csWebUser myModel)
        {
            if (ModelState.IsValid)
            {

            }

            return Content("user selected country "+myModel.userCountry);
        }

        public IActionResult Form2(csWebUser myModel)
        {
            if (ModelState.IsValid)
            {

            }
            myModel.FirstName = "Furkan";
            return Content("user selected language id " + myModel.userLanguageId);
        }

        [HttpPost]
        public IActionResult UpdateEntry(string text1,string text2)
        {
            return Content($"update successfull text1: {text1} - text2: {text2}");
        }
    }
}