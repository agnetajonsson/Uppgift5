using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    class MC : Vehicle
    {
        public int cylindervolume;
        public int CylinderVolume
        {
            get
            {
                return cylindervolume;
            }
            set
            {
                if (value > 0)

                    cylindervolume = value;
            }
        }
        public MC(string regno, string vehicletype, string color, int wheel, int cylindervolume) : base(regno, vehicletype, color, wheel)
        {
            CylinderVolume = cylindervolume;

        }
        public string Something { get; }
        public override string Stats()
        {
            return base.Stats() + $", Cylindervolume: {CylinderVolume}";
        }
    }
}
