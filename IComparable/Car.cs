using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    // This class implements the IComparable class in generic way
    class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int Maxph { get; set; }
        public int HorsePower { get; set; }
        public decimal Price { get; set; }

        // Compare Cars alphabetically by name
        public int CompareTo(Car other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }

    // This class implements the IComparable class in plain way
    /*class Car : IComparable
    {
        public string Name { get; set; }
        public int Maxph { get; set; }
        public int HorsePower { get; set; }
        public int Price { get; set; }

        // Compare Cars alphabetically by name
        public int CompareTo(Object obj)
        {
            // Validate whether the obj is Car obj
            if(!obj is Car)
            {
                throw new ArgumentException("Object is not a Car");
            }
            Car other = obj as Car;
            return Name.CompareTo(other.Name);
        }
    }*/
}
