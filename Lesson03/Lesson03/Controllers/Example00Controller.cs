using System.Collections.Generic;
using Lesson03.Models;
using lesson03_examples.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson03.Controllers
{
    public class Example00Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Moms = Product.Moms;
            
            // Illegal - cannot assign a new value to a read-only property
            // Product.Moms = 0.2M;
            return View();
        }
    }
}