using Lesson01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public IActionResult Index()
        {
            ViewBag.Movie = "One Flew Over the Cuckoo's Nest";
            ViewBag.Year = 1975;
            return View();
        }
  
    }
}