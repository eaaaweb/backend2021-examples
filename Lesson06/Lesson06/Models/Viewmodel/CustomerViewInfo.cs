using Lesson06.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lesson06.Models.ViewModels
{
    // viewmodel class
    public class CustomerViewInfo
    {
        public Customer Customer { get; set; } 
        public IEnumerable<SelectListItem> CountrySelectList { get; }

        // constructor
        public CustomerViewInfo()
        {
            Customer = new Customer();

            CountrySelectList = new List<SelectListItem> {
                new SelectListItem{ Value = "dk", Text = "Denmark" },
                new SelectListItem{ Value = "no", Text = "Norway" },
                new SelectListItem{ Value = "de", Text = "Germany" },
                new SelectListItem{ Value = "se", Text = "Sweden" }
            };
        }
    }

}
