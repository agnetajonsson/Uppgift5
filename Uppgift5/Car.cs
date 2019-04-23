using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    class Car : Vehicle
    {
        public string fueltype;
        public string Fueltype
        {
            get
            {
                return fueltype;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))

                    fueltype = value;
            }
        }
        public Car(string regno, string vehicletype, string color, string fueltype) : base(regno, vehicletype, color)
        {
            Fueltype = fueltype;
        }
    }



}
