using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisAndBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Results = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some data - populate people
            Results += "Making Person(Bea)" + Environment.NewLine;
            Person bea = new Person("Bea");
            Results += Environment.NewLine;

            Results += "Making Person(George, Lastman)" + Environment.NewLine;
            Person george = new Person("George", "Lastman");
            Results += Environment.NewLine;

            Results += "Making Employee(Stephen)" + Environment.NewLine;
            Employee stephen = new Employee("Stephen");
            Results += Environment.NewLine;

            Results += "Making Employee(Jessica, Parker)" + Environment.NewLine;
            Employee jessica = new Employee("Jessica", "Parker");
            Results += Environment.NewLine;

            Results += "Making Employee(Jasmine, Tookes, Fashion)" + Environment.NewLine;
            Employee jasmine = new Employee("Jasmine", "Tookes", "Fashion");
            Results += Environment.NewLine;

            resultsTextBox.Text += Results;
            resultsTextBox.Select(0, 0);
        }
 
    }
}
