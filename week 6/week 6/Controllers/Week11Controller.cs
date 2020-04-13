using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace week_6.Controllers
{
    public class Week11Controller : Controller
    {
        public IActionResult Index()
        {
        
            HttpContext.Response.Cookies.Append("user_id", "1");
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(new DateTime(2021, 1, 1));
            cookieOptions.Domain = ".mywebsite.com";
            HttpContext.Response.Cookies.Append("this_is_a_long_cookie", "it will expire at 2021-01-01", cookieOptions);

            cookieOptions.Path = "/";
            HttpContext.Response.Cookies.Append("path_cookie", "path_cookie", cookieOptions);
            var path_cookie = HttpContext.Request.Cookies["path_cookie"];
            return View();
        }
     
        public IActionResult QueryTest()
        {
            string name = "default name";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
                name = HttpContext.Request.Query["name"];
            return Content(name);
        }

        [Route("/week11/formtest")]
        public IActionResult formtest()
        {
            string srDefaultAge = "20";
            string srDefaultName = "default name";
            if (!String.IsNullOrEmpty(HttpContext.Request.Form["UserName"]))
                srDefaultName = HttpContext.Request.Form["UserName"];
            if (!String.IsNullOrEmpty(HttpContext.Request.Form["UserAge"]))
                srDefaultAge = HttpContext.Request.Form["UserAge"];
            return Content(srDefaultAge+" "+ srDefaultName);
        }

        [ResponseCache(Duration = 180)]
        [Route("/week11/cache")]
        public IActionResult cache()
        {
            
            return Content("cached content");
        }
        private IMemoryCache _memoryCache;

        public Week11Controller(IMemoryCache memoryCache)
        {
            this._memoryCache = memoryCache;
        }

        public IActionResult memorycache()
        {
         
            string cacheKey = DateTime.Now.ToString("yyyyMMddHHmm");
            string cachedMessage;

            if (!this._memoryCache.TryGetValue(cacheKey, out cachedMessage))
            {
                // Create a fake delay of 3 seconds to simulate heavy processing...
                System.Threading.Thread.Sleep(3000);

                cachedMessage = "Cache was last refreshed @ " + DateTime.Now;
                this._memoryCache.Set(cacheKey, cachedMessage, DateTime.Now.AddSeconds(5));
            }

            return Content(cachedMessage);
        }
    }
}