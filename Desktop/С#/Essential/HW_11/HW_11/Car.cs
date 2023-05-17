using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11
{
    internal class Car
    {
        public string CarName { get; set; }
        public int CarYearOfManufacture { get; set; }
        public Car(string carName, int carYearOfManufacture)
        {
            CarName = carName;
            CarYearOfManufacture = carYearOfManufacture;
        }
    }
}
