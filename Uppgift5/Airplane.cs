using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    class Airplane : Vehicle
    {
        public int numberofengine;
        public int NumberOfEngine
        {
            get
            {
                return numberofengine;
            }
            set
            {
                if (value > 0)

                    numberofengine = value;
            }
        }
        public Airplane(string regno, string vehicletype, string color, int wheel, int numberofengine) : base(regno, vehicletype, color, wheel)
        {
            NumberOfEngine = numberofengine;
        }
        public string Something { get; }
        public override string Stats()
        {
            return base.Stats() + $", Number of engine: {NumberOfEngine}";
        }
    }
}
