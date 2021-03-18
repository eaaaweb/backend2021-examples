using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace lesson06_examples.Controllers
{
    public class CatchAllController : Controller
    {
        // GET: Question01
        public string Index(string catchall)
        {
            return "Controller: CatchAll <br /> Action: Index <br /> Catchall: " + catchall;

        }
    }
}




