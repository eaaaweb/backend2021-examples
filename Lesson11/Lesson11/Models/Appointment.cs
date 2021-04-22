using lesson11.Infrastructure.ModelValidation.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace lesson11.Models
{
    public class Appointment {

        [Required(ErrorMessage = "The name is required")]
        public string FullName { get; set; }

        [Remote("FutureDateValidation", "Home")]
        [FutureDate]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}