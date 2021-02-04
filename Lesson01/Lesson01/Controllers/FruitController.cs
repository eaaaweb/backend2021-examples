using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01.Controllers
{
    public class FruitController : Controller
    {
        // GET: Fruit
        public IActionResult Index()
        {
            string[] fruits = new string[] { "Apple", "Orange", "Pear", "Banana", "Plum" };
            ViewBag.Fruits = fruits;

            return View();
        }
    }
}


