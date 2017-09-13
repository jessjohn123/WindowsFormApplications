using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some data
            Car[] cars =
            {
                new Car(){  Name = "SSC Ultimate Aero",MaxMph = 257, HorsePower = 1183, Price=654400m},
                new Car(){  Name = "Bugatti Veyron", MaxMph = 253, HorsePower = 1001, Price=1700000m},
                new Car(){  Name = "Saleen S7 Twin-Turbo", MaxMph = 248, HorsePower = 750, Price=555000m},
                new Car(){  Name = "Koenigsegg CCX", MaxMph = 245, HorsePower = 806, Price=545568m},
                new Car(){  Name = "McLaren F1", MaxMph = 240, HorsePower = 637, Price=970000m},
                new Car(){  Name = "Ferrari Enzo", MaxMph = 217, HorsePower = 660, Price=670000m},
                new Car(){  Name = "Jaguar XJ220", MaxMph = 217, HorsePower = 542, Price=650000m}
            };

            // Display the cars unsorted
            DisplayCars(cars, unsortedListView);

            // Sort the cars aplhabetically
            Array.Sort(cars);

            // Display the cars sorted
            DisplayCars(cars, sortedListView);

        }

        private void DisplayCars(Car [] cars, ListView listview)
        {
            // Clear the list views
            listview.Items.Clear();

            // For each car object, display its properties
            foreach(Car c in cars)
            {
                ListViewItem item = listview.Items.Add(c.Name);
                item.SubItems.Add(c.MaxMph.ToString());
                item.SubItems.Add(c.HorsePower.ToString());
                item.SubItems.Add(c.Price.ToString());
            }

            // Set each list view's column property to-2
            foreach(ColumnHeader col in listview.Columns)
            {
                col.Width = -2;
            }
        }

        private void unsortedListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
