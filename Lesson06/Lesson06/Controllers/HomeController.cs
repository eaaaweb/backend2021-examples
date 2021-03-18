using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace lesson06_examples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public IActionResult Index()
        //{
        //    return Content(string.Format("Home/index is called"));
        //}

        public IActionResult Index(int? id)
        {
            return Content(string.Format("The id parameter is {0}", id));
        }
    }
}