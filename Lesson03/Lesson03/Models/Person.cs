using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson03_examples.Models
{
    public class Person
    {
        protected int personId;
        protected string firstname;
        protected string lastname;

        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public Person(int personId, string firstname, string lastname)
        {
            this.personId = personId;
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public virtual string GetAsString()
        {
            string s = "Person: " + firstname
                          + " " + lastname;
            return s;
        }

        public override string ToString()
        {
            return firstname + " " + lastname;
        }


    }

}