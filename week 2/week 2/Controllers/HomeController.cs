using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace week_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //new means compose an instance an object of that class
            //We instantiated a new Movie object
            Models.Movie myMovieCs = new Models.Movie()
            {
                srTitle = "The Godfather 3",
                dtReleaseDate = new DateTime(1964, 11, 15, 23, 15, 05),
                srMyName = "Furkan Gözükara"
            };

           return View(myMovieCs);
        }

        public IActionResult Index2()
        {
            return View("Index2");
        }
    }
}
