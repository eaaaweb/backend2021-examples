using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson02.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // C# 5
        public string Fullname_C5 {
            get {
                return FirstName + " " + LastName;
            }
        }

        // C# 6
        public string Fullname => FirstName + " " + LastName;



    }
}
