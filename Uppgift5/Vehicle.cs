using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    class Vehicle
    {

        private string regno;
        public string Regno
        {
            get
            {
                return regno;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    regno = value;
            }
        }

        private string vehicletype;
        public string VehicleType
        {
            get
            {
                return vehicletype;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    vehicletype = value;
            }
        }

        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    color = value;
            }
        }

        public Vehicle(string regno, string vehicletype, string color)

        {
            VehicleType = vehicletype;
            Color = color;
            Regno = regno;
        }
    }
}
