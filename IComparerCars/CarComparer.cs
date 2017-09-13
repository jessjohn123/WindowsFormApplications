using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerCars
{
    class CarComparer : IComparer<Car>
    {
        // Which fields to use while comparing two car objects
        public enum CompareField
        {
            Name,
            MaxPH,
            HorsePower,
            Price,
        }

        public CompareField sortBy = CompareField.Name;

        // This method examines the sortby value and compares two objects
        public int Compare(Car x, Car y)
        {
            switch (sortBy)
            {
                case CompareField.Name:
                    return x.Name.CompareTo(y.Name);
                case CompareField.MaxPH:
                    return x.MaxMph.CompareTo(y.MaxMph);
                case CompareField.HorsePower:
                    return x.HorsePower.CompareTo(y.HorsePower);
                case CompareField.Price:
                    return x.Price.CompareTo(y.Price);
            }
            return x.Name.CompareTo(y.Name);
        }
    }
}
