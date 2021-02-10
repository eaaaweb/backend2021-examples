using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Controllers
{
    public class SimpleDatatypeObjectsController : Controller
    {
        public IActionResult Index()
        {
            int i = 12; // object
            string s = i.ToString(); // method
            int j = s.Length; // property

            ViewBag.Integer = i;
            ViewBag.String = s;
            ViewBag.StringLength = j;


            return View();
        }
    }
}