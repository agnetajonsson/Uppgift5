using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    class Boat : Vehicle
    {
        public int lenght;
        public int Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value > 0)

                    lenght = value;
            }
        }
        public Boat(string regno, string vehicletype, string color, int wheel, int lenght) : base(regno, vehicletype, color, wheel)
        {
            Lenght = lenght;
        }
        public string Something { get; }
        public override string Stats()
        {
            return base.Stats() + $", Lenght: {Lenght}";
        }
    }
}
