using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
   public class Vehicle
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
        public int wheel;
        public int Wheel
        {
            get
            {
                return wheel;
            }
            set
            {
                if (value > 0)
                    wheel = value;
            }
        }

        // konstruktorn för vehicle
        public Vehicle(string regno, string vehicletype, string color, int wheel)
        {
            Regno = regno;
            VehicleType = vehicletype;
            Color = color;
            Wheel = wheel;
        }

        public virtual string Stats()
        {
            string returnString = $"Regno: {Regno} , Vehicletype: {VehicleType} , Color: {Color} , Wheel: {Wheel}";
           
            return returnString;
        }
    }
}
