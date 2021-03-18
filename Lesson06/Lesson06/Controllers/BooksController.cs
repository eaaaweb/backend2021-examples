using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace lesson06_examples.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public IActionResult Index(string category = "", string title = "")
        {
            string s = "Books controller";
            if (category.Length > 0) {
                s += "<br>Category: " + category;
            }
            if (title.Length > 0) {
                s += "<br>Title: " + title;
            }
            return Content(string.Format("The action result is sent from:<br/> {0}", s));
        }
    }
}