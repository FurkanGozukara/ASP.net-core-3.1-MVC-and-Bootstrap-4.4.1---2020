using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace week_6.Controllers
{
    public class MovieController : Controller
    {
        [Route("Movie")]
        public IActionResult Index()
        {
            Models.Movie myMov = new Models.Movie
            {
                lstMovies = new List<Models.Movie.PerMovie>
              {
                  new Models.Movie.PerMovie
                  {
                       MovieId=3,
                       MovieName="Film 1"
                  },   new Models.Movie.PerMovie
                  {
                       MovieId=4,
                       MovieName="Film 2"
                  }
              }
            };
            return View(myMov);
        }

        [Route("Movie/Details")]
        public IActionResult Details(int id)
        {
            return Content("selected movie id " + id);
        }
    }
}