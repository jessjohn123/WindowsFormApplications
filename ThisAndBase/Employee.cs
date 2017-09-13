using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAndBase
{
    class Employee : Person
    {
        public string DepartmentName { get; set; }

        public Employee(string firstName) : base(firstName)
        {
            // Add msg to forms.1 to keep track of whats happening
            Form1.Results += "    Employee(" + firstName + ")" + Environment.NewLine;
        }
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
            // Add msg to forms.1 to keep track of whats happening
            Form1.Results += "    Employee(" + firstName + ", " +
            lastName + ")" + Environment.NewLine;
        }
        public Employee(string firstName, string lastName, string departmentName) : this(firstName,lastName)
        {
            // Validate department name
            if((departmentName == null) || (departmentName.Length < 1))
            {
                throw new ArgumentOutOfRangeException("departmentName", departmentName, "Department Name should not be null or blank.");
            }
            // Add msg to forms.1 to keep track of whats happening
            Form1.Results += "    Employee(" + firstName + ", " +
            lastName + ", " + departmentName + ")" + Environment.NewLine;
            // Save it
            DepartmentName = departmentName;
        }
    }
}
