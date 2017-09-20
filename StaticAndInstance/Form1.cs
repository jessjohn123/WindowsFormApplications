using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticAndInstance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Some Person Data
            Person alice = new Person() { Name = "Alice" };
            Person bob = new Person() { Name = "Bob" };

            //Alice's InstanceMethd var to get her own names
            alice.InstanceMethod = alice.GetName;
            alice.StaticMethod = Person.StaticName;

            //Make Bob's InstanceMethod refer to Alice's GetName ()
            bob.InstanceMethod = alice.GetName;
            bob.StaticMethod = Person.StaticName;

            string result = "";
            result += "Alice's InstanceMethod returns: " + alice.InstanceMethod() + Environment.NewLine;
            result += "Bob's InstanceMethod returns: " + bob.InstanceMethod() + Environment.NewLine;
            result += "Alice's StaticMethod returns: " + alice.StaticMethod() + Environment.NewLine;
            result += "Bob's StaticMethod returns: " + bob.StaticMethod();

            resultTextBox.Text = result;
            resultTextBox.Select(0, 0);

        }
    }
}
