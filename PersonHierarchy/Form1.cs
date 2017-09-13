using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonHierarchy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person person = new Person("Ann", "Archer");
            Employee employee = new Employee("Jose", "Thunder", "IT");
        }

        // SuperClass or BaseClass or ParentClass
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string firstName, string lastName)
            {
                // Validate first and last name
                if((firstName == null) || (firstName.Length < 1))
                {
                    throw new ArgumentOutOfRangeException("firstName", firstName, "First Name should not be null or blank.");
                }
                if((lastName == null) || (lastName.Length < 1))
                {
                    throw new ArgumentOutOfRangeException("lastName", lastName, "Last Name should not be null or blank");
                }

                // Save it
                FirstName = firstName;
                LastName = lastName;
            }
        }

        // DerivedClass or ChildClass or SubClass
        public class Employee : Person
        {
            public string DepartmentCategory { get; set; }
            public Employee(string firstName, string lastName, string departmentCategory) : base(firstName, lastName)
            {
                // Validate department category
                if((departmentCategory == null) || (departmentCategory.Length < 1))
                {
                    throw new ArgumentOutOfRangeException("departmentCategory", departmentCategory, "Department Category cannot be null or blank");
                }

                // Save it
                DepartmentCategory = departmentCategory;
            }
        }
    }
}
