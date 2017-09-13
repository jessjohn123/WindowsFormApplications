using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAndBase
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName)
        {
            // Validate first name
            if ((firstName == null) || (firstName.Length < 1))
            {
                throw new ArgumentOutOfRangeException("firstName", firstName, "First Name should not be null or blank.");
            }
           
            // Add a msg to forms.1 to keep track of what's happening
            Form1.Results += " Person(" + firstName + ")" + Environment.NewLine;
            // Save it
            FirstName = firstName;
        }

        public Person(string firstName, string lastName) : this(firstName)
        {
            // Validate last name
            if ((lastName == null) || (lastName.Length < 1))
            {
                throw new ArgumentOutOfRangeException("lastName", lastName, "Last Name should not be null or blank");
            }

            // Add a msg to forms.1 to keep track of what's happening
            Form1.Results += " Person(" + firstName + ", " + lastName + ")" + Environment.NewLine;
            // Save it
            LastName = lastName;
        }
    }
}
