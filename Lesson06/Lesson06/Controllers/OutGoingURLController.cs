using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace lesson06_examples.Controllers
{
    public class OutGoingURLController : Controller
    {
        // GET: OutGoingURL
        public IActionResult Index()
        {
            return View();
        }
    }
}