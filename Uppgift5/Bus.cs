using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    class Bus : Vehicle
    {
        public int numberofseats;
        public int NumberOfSeats
        {
            get
            {
                return numberofseats;
            }
            set
            {
                if (value > 0)

                    numberofseats = value;
            }
        }
        public Bus(string regno, string vehicletype, string color, int wheel, int numberofseats) : base(regno, vehicletype, color, wheel)
        {
            NumberOfSeats = numberofseats;
        }
        public string Something { get; }

        public override string Stats()
        {
            return base.Stats() + $", Number of seats: {NumberOfSeats}";
        }
    }
}
