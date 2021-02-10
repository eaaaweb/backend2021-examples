using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Controllers
{
    public class DiceController : Controller
    {
        public IActionResult Index()
        {
            return View();  // method of the Controller class, 
                            // that returns an ActionResult object (View)
        }

        // POST
        [HttpPost]
        public IActionResult Index(IFormCollection fc)
        {
            // Create a new Random object 
            Random rnd = new Random(); // rnd is a variable of type Random

            // Next(1, 7) (method) returns a random number between 1 and 7 (exclusive)
            int i = rnd.Next(1, 7);

            ViewBag.Face = i; // ViewBag: Object; ViewBag.Face // Property 
            return View(); // View is a method of the Controller class
        }
    }
}