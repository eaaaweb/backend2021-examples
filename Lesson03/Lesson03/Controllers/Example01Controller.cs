using System.Collections.Generic;
using lesson03_examples.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson03.Controllers
{
    public class Example01Controller : Controller
    {
        public IActionResult Index()
        {
            Person p1, p2, p3;
            p1 = new Person("Susan", "Taylor");
            p2 = new Employee("Bob", "Stern", 20);
            p3 = new Employee("Tina", "Raymond", 37);

            List<Person> persons = new List<Person>();
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            ViewBag.Persons = persons;

            return View(); 
        }
    }
}