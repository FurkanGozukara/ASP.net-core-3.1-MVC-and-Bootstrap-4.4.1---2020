using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace week_6.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if ((exceptionHandlerPathFeature != null) && (exceptionHandlerPathFeature.Error != null))
            {
                return Content(exceptionHandlerPathFeature.Error.StackTrace.ToString());
            }
            return View("Error");
        }

        public IActionResult Http(int statusCode)
        {
            return Content("error status code is " + statusCode);
        }
    }
}