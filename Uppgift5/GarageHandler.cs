using System;

namespace Uppgift5
{
    internal class GarageHandler
    {
        public Garage<Vehicle> CreateGarage(string name, int parkingplaces)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(name, parkingplaces);

            return garage;

        }
        public void SetPlaces(Garage<Vehicle> garage, string name, int parkingplaces)
        {
            garage.Name = name;
            garage.ParkingPlaces = parkingplaces;

            {
                //Console.WriteLine("Skriver från GarageHandler Namn:" + garage.Name + " Parkeringsplatser: " + garage.ParkingPlaces);
                //Console.ReadLine();
            }
        }

    }        
}