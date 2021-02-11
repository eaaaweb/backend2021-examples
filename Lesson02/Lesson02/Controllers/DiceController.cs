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
            return View();  
        }

        // POST
        [HttpPost]
        public IActionResult Index(IFormCollection fc)
        {
            Random rnd = new Random(); 

            int i = rnd.Next(1, 7);

            ViewBag.Face = i; 
            return View(); 
        }
    }
}