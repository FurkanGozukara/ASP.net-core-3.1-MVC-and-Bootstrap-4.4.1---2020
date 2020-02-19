using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace week_2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index(int Id)
        {
            return Content("Product details for #" + Id);
        }
    }
}