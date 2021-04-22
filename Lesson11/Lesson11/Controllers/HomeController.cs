using lesson11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace lesson11.Controllers
{
    public class HomeController : Controller {

        // GET: Home
        public IActionResult Index() => View();

        

        // GET: Home
        public IActionResult CreateBooking() {
            return View(new Appointment { Date = DateTime.Now });
        }



        [HttpPost]
        public IActionResult CreateBooking(Appointment appt) {

            if (!ModelState.IsValid) {
                return View();
            }
            else {
                // store new Appointment in repository 
                return View("Completed", appt);   
            }
        }

        // Explicit Validation
         [HttpPost]
        public IActionResult CreateBookingWithExplicitValidation(Appointment appt) {

            // Explicit validation
            if (string.IsNullOrEmpty(appt.FullName))
            {
                ModelState.AddModelError("FullName", "Please enter your name");
            }

            if (appt.Date == null || appt.Date <= DateTime.Now)
            {
                ModelState.AddModelError("Date", "Please enter a date in the future");
            }

            if (ModelState.GetValidationState(nameof(appt.Date)) == ModelValidationState.Valid
                && ModelState.GetValidationState(nameof(appt.FullName)) == ModelValidationState.Valid
                && appt.FullName.Equals("Joe", StringComparison.OrdinalIgnoreCase)
                && appt.Date.DayOfWeek == DayOfWeek.Monday)
            {
                ModelState.AddModelError("",
                "Joe cannot book appointments on Mondays");
            }


            if (ModelState.IsValid) {
                // store new Appointment in repository 
                return View("Completed", appt);
            }
            else {
                return View("CreateBooking");
            }
        }

       
        public JsonResult FutureDateValidation(string Date) {
            DateTime parsedDate;
            if (!DateTime.TryParse(Date, out parsedDate)) {
                return Json("Please enter a valid date (dd-mm-yyyy)");
            }
            else if (DateTime.Now > parsedDate) {
                return Json("Please enter a date in the future");
            }
            else {
                return Json(true);
            }
        }


        public IActionResult PersonRegistration() => View("PersonRegistration", new Person { Birthday = DateTime.Now });
           

        [HttpPost]
        public IActionResult PersonRegistration(Person person) {
            if (ModelState.IsValid) {
                // store new Appointment in repository 
                return View("RegistrationCompleted", person);
            }
            else {
                return View();
            }
        
        }
    }
}