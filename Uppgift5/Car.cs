using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
   public class Car : Vehicle
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
        public Car(string regno, string vehicletype, string color, int wheel, string fueltype) : base(regno, vehicletype, color, wheel)
        {
            Fueltype = fueltype;
        }
        public string Something { get; }
        public override string Stats()

        {
            return base.Stats() + $", Fueltype: {Fueltype}";
        }
    }
}