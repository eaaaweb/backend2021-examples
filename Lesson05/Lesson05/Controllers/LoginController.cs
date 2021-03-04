using Lesson05.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson05.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Login login = new Login();
            return View(login);
        }


        [HttpPost]
        public IActionResult Index(Login login)
        {
            return View(login);
        }
    }
}