using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01.Controllers
{
    public class ArrayOfIntController : Controller
    {
        // GET: ArrayOfInt
        public IActionResult Index()
        {
            return View();
        }
    }
}