using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Controllers
{
  

    public class HomeController : Controller
    {
        public IActionResult Index() 
        { 
            return View(); 
        }

        // or alternatively with lambda expression (Expression-Bodied Method)
        // public IActionResult Index() => View();

    }
}