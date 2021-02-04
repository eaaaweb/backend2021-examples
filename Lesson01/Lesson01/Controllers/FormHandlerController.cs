using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01.Controllers
{
    public class FormHandlerController : Controller
    {
        // GET: FormHandler
        public IActionResult Index()
        {
            return View();
        }
        
        // POST: FormHandler
        [HttpPost]
        public IActionResult Index(IFormCollection formCollection) {
            ViewBag.Firstname = formCollection["Firstname"];
            ViewBag.Lastname = formCollection["Lastname"];
            return View();
        }
    }

}


