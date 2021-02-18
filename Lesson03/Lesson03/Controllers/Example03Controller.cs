using System.Collections.Generic;
using lesson03_examples.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson03.Controllers
{
    public class Example03Controller : Controller
    {
        public IActionResult Index()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person(1, "Susan", "Taylor"));
            persons.Add(new Employee(2, "Bob", "Stern", 20));

            // return a strongly typed view
            return View(persons as IEnumerable<Person>);
        }
    }
}