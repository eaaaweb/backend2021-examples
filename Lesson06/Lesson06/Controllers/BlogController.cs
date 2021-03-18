using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace lesson06_examples.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public string Postbydate(int year, int month, int day, string title)
        {
            return "Blogpost: " + year.ToString() + "/" + month.ToString() + "/" + day.ToString() + ". Title: " + title;
        }
        public string Postbytitle(string title) {
            return "Blogpost title: " + title;
        }

    }
}