using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using week_6.CustomClasses;

namespace week_6.Controllers
{
    public class Week9Controller : Controller
    {
        private CustomClasses.CustomUser myCustomUser;

        [Route("Week9")]
        public IActionResult Index()
        {
            initData();
            return View("Week9", myCustomUser);
        }

        private void initData()
        {
            myCustomUser = GlobalFunctions.GetSessionData<CustomClasses.CustomUser>(HttpContext.Session, GlobalFunctions.srUserInfoKey);
        }

        [Route("Week9/Error")]
        public IActionResult Error()
        {
            return Content(Convert.ToInt32("error").ToString());
        }
        public IActionResult SetAuth(string username, string password)
        {

            CustomClasses.CustomUser myUser = new CustomClasses.CustomUser
            {
                srUsername = username,
                srPassword = password,
                srUserId = DateTime.Now.Ticks.ToString()
            };

            GlobalFunctions.SetSessionData(HttpContext.Session, GlobalFunctions.srUserInfoKey, myUser);
            initData();
            return View("Week9", myCustomUser);
        }
    }
}