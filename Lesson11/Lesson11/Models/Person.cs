//using lesson11.Infrastructure.ModelValidation.Infrastructure;
using lesson11.Infrastructure.ModelValidation.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lesson11.Models {
    public class Person {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [UIHint("Date")]
        [OldEnough(ErrorMessage = "There is something wrong with the birthday")]
        public DateTime Birthday { get; set; }
    }
}
