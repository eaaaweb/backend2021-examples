using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson06.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson06.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
         
            return View(new CustomerViewInfo());
        }
    }
}