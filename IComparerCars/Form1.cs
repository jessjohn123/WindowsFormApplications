using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparerCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Cars.
        private Car[] Cars;

        private void Form1_Load(object sender, EventArgs e)
        {
            sortByComboBox.SelectedIndex = 0;

            Cars = new Car[]
           {
                new Car(){  Name = "SSC Ultimate Aero",MaxMph = 257, HorsePower = 1183, Price=654400m},
                new Car(){  Name = "Bugatti Veyron", MaxMph = 253, HorsePower = 1001, Price=1700000m},
                new Car(){  Name = "Saleen S7 Twin-Turbo", MaxMph = 248, HorsePower = 750, Price=555000m},
                new Car(){  Name = "Koenigsegg CCX", MaxMph = 245, HorsePower = 806, Price=545568m},
                new Car(){  Name = "McLaren F1", MaxMph = 240, HorsePower = 637, Price=970000m},
                new Car(){  Name = "Ferrari Enzo", MaxMph = 217, HorsePower = 660, Price=670000m},
                new Car(){  Name = "Jaguar XJ220", MaxMph = 217, HorsePower = 542, Price=650000m}
            };

            DisplayCars();

        }

        private void DisplayCars()
        {
            if (Cars == null) return;

            // Make the approp comparer
            CarComparer cc = new CarComparer();
            if (sortByComboBox.Text == "Name")
                cc.sortBy = CarComparer.CompareField.Name;
            else if (sortByComboBox.Text == "MaxMph")
                cc.sortBy = CarComparer.CompareField.MaxPH;
            else if (sortByComboBox.Text == "HorsePower")
                cc.sortBy = CarComparer.CompareField.HorsePower;
            else
                cc.sortBy = CarComparer.CompareField.Price;

            // Sort
            Array.Sort(Cars, cc);

            // If it is not sorted by NAME,reverse the array
            if (sortByComboBox.Text != "Name") Array.Reverse(Cars);

            carListView.Items.Clear();
            foreach (Car car in Cars)
            {
                ListViewItem item = carListView.Items.Add(car.Name);
                item.SubItems.Add(car.MaxMph.ToString());
                item.SubItems.Add(car.HorsePower.ToString());
                item.SubItems.Add(car.Price.ToString("C"));
            }
            foreach (ColumnHeader header in carListView.Columns)
            {
                header.Width = -2;
            }

        }

       

        private void sortByComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DisplayCars();
        }
    }
}
