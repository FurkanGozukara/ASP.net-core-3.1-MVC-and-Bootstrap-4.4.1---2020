using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace week_2.Controllers
{
    public class ProductsController : Controller
    {
        [Route("/product")]
        public IActionResult Index()
        {
            return Content("Product content");
        }

        [Route("/product/{name:minlength(2)}", Order = 5)]
        public IActionResult Name(string name)
        {
            return Content("entered product title: " + name);
        }

        [Route("/deneme/{id}")]
        [Route("{id}", Order = 11)]
        [Route("{id}/{id2}", Order = 22)]
        public IActionResult Details(int id, int id2)
        {
            return Content("Product details for #" + id + " id2: " + id2);
        }


        [Route("/product/{id}", Order = 3)]
        public IActionResult Details2(int id)
        {
            return Content("Product details 2 for #" + id);
        }

        [Route("/product/{id}", Order = 2)]
        public IActionResult Details3(int id)
        {
            return Content("Product details 3 for #" + id);
        }

        [Route("/product/{id:range(50,90)}", Order = 1)]
        public IActionResult Details4(int id)
        {
            return Content("Product details range restriction for #" + id);
        }
    }
}