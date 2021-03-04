using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson05.Models;
using Lesson05.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson05.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            SelectListViewModel selectListViewModel = new SelectListViewModel();
            ViewBag.CountryList = selectListViewModel.CountryList;

            Person person = new Person();
            return View(person);
        }


        [HttpPost]
        public IActionResult Index(Person person)
        {
            SelectListViewModel selectListViewModel = new SelectListViewModel();
            ViewBag.CountryList = selectListViewModel.CountryList;

            return View(person);
        }
    }
}