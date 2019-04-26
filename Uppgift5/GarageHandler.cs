using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Uppgift5
{
    internal class GarageHandler
    {
        Garage<Vehicle> garage;
        public static string menyval { get; set; }
        public static string Regno { get; private set; }
        public static string VehicleType { get; private set; }
        public static string Color { get; private set; }
        public static int Wheel { get; private set; }
        public bool CreateGarage(string name, int capacity)
        {
            garage = new Garage<Vehicle>(name, capacity);
            Console.WriteLine($"Name: {garage.Name}, Number of parking places: { garage.Capacity}");
            
            Console.WriteLine($"Number of vehicle: { garage.Count}");
            return true;
        }
      //metod för createVehicle
        public void CreateVehicle(string regno, string vehicletype, string color, int wheel)
        {
            var vehicle = new Vehicle(regno, vehicletype, color, wheel);
            garage.Add(vehicle);
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            return garage.ToList();
        }

        public void SetPlaces( string name, int capacity)
        {
            garage.Name = name;
           // garage.ParkingPlaces = capacity;

            {
                //Console.WriteLine("Skriver från GarageHandler Namn:" + garage.Name + " Parkeringsplatser: " + garage.ParkingPlaces);
                //Console.ReadLine();
            }
        }

        internal void CreateVehicle(object regno, object vehicletype, object color, object wheel)
        {
            throw new NotImplementedException();
        }
    }
}