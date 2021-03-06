﻿using System;
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
        public IActionResult Index(int id)
        {
            //new means compose an instance an object of that class
            //We instantiated a new Movie object
            Models.Movie myMovieCs = new Models.Movie()
            {
                srTitle = "The Godfather 3",
                dtReleaseDate = new DateTime(1964, 11, 15, 23, 15, 05),
                srMyName = "Furkan Gözükara : id=" + id
            };

           return View(myMovieCs);
        }

        public class mainTestModel
        {
            public ViewModels.AdressViewModel addModel;
            public Models.Cars carModel;
        }

        public IActionResult Test()
        {
            Models.Cars myCar = new Models.Cars
            {
                irCarPrice = 412,
                srCarBrand = "bmw"
            };
            ViewModels.AdressViewModel adresModel = new ViewModels.AdressViewModel
            {
                StreetName = "Toros Mah.",
                ZipCode = "32122"
            };
            mainTestModel mainModel = new mainTestModel { addModel = adresModel, carModel = myCar };
            return View("Test2", mainModel);
        }

        public IActionResult Bus()
        {
            Models.Cars myCar = new Models.Cars
            {
                irCarPrice = 234234,
                srCarBrand = "busss"
            };
            return View("/Views/Test/Bus3.cshtml", myCar);
        }

        public IActionResult Deneme()
        {
            return View("Deneme");
        }

    }
}
