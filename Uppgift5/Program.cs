using System;
using System.Collections.Generic;

namespace Uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            GarageHandler garagehandler = new GarageHandler();
            Garage<Vehicle> garage = garagehandler.CreateGarage("Citygaraget", 500);

            Console.WriteLine($"Name: {garage.Name}, Number of parking places: { garage.ParkingPlaces}");

        }
    }
}
