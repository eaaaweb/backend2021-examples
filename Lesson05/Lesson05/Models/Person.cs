using System;
using System.ComponentModel.DataAnnotations;

namespace Lesson05.Models
{
        public class Person
        {
            public int PersonId { get; set; }

            [Display(Name = "First name")]
            public string FirstName { get; set; }

            [Display(Name = "Last name")]
            public string LastName { get; set; }

            [Display(Name = "Birthday")]
            [DataType(DataType.Date)]
            public DateTime BirthDay { get; set; } = DateTime.Now;

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            public string Country { get; set; }

        [MaxLength(1024)]
        public string Note { get; set; }

            //public string FavouritColour { get; set; }
    }
}
