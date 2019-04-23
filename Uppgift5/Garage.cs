using System;

namespace Uppgift5
{
    class Garage<T> where T : Vehicle
    {
        private string name;
        public string Name

        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        private int parkingplaces;
        public int ParkingPlaces
        {
            get
            {
                return parkingplaces;
            }
            set
            {
                if (value > 0)
                    parkingplaces = value;
            }
        }

        public Garage(string name, int parkingplaces) // konstruktor för garage
        {
            Name = name;
            ParkingPlaces = parkingplaces;
        }
                
    }
}