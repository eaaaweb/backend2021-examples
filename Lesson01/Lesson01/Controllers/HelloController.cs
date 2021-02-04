using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01.Controllers
{
    public class HelloController : Controller
    {
        // GET: Home
        public IActionResult Index()
        {
            return View();
        }
    }
}