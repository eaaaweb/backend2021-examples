using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01.Controllers
{
    public class DateTimeController : Controller
    {
        // GET: DateTime
        public IActionResult Index()
        {

            DateTime dt1 = new DateTime(2015, 7, 30);
            DateTime dt2 = new DateTime(2014, 9, 1, 9, 20, 40);


            ViewBag.DT1 = dt1;
            ViewBag.DT2 = dt2;


            return View();
        }
    }
}