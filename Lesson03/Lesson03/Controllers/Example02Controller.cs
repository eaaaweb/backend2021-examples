using System.Collections.Generic;
using lesson03_examples.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson03.Controllers
{
    public class Example02Controller : Controller
    {
        public IActionResult Index()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person(1, "Susan", "Taylor"));
            persons.Add(new Employee(2, "Bob", "Stern", 20));
            
            // Dropdown list
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (Person p in persons)
            {
                items.Add(new SelectListItem { Text = p.ToString(), Value = p.PersonId.ToString() });
            }
            ViewBag.Persons = items;

            return View();
        }
    }
}