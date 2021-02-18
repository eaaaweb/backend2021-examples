using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson03_examples.Models
{
    public class Employee : Person
    {
        private int weeklyHours;
        public int WeeklyHours
        {
            get { return weeklyHours; }
            set { weeklyHours = value; }
        }

        public Employee(string firstname, string lastname,
              int weeklyHours) : base(firstname, lastname)
        {
            this.weeklyHours = weeklyHours;
        }



        public Employee(int personId, string firstname, string lastname,
              int weeklyHours) : base(personId, firstname, lastname)
        {
            this.weeklyHours = weeklyHours;
        }

        public override string GetAsString()
        {
            string s = "Employee: ";
            s += firstname;
            s += " " + lastname;
            s += " [" + weeklyHours + "] ";
            return s;
        }

    }

}