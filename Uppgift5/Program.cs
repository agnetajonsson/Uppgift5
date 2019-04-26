using System;
using System.Drawing;
using System.Collections.Generic;

namespace Uppgift5
{
    class Program
    {
        public static string menyval { get; set; }
        public static string Regno { get; private set; }
        public static string VehicleType { get; private set; }
        public static string Color { get; private set; }
        public static int Wheel { get; private set; }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            GarageHandler garagehandler = new GarageHandler();
            bool garageOK = garagehandler.CreateGarage("Citygaraget", 500);

            //Console.WriteLine($"Name: {garage.Name}, Number of parking places: { garage.ParkingPlaces}");
           
            Console.WriteLine("Du har kommit till huvudmenyn");

            do
            {
                Console.WriteLine("Menyval 1: Lista alla parkerade fordon ");
                Console.WriteLine("Menyval 2: Lista fordonstyper och hur många av varje som står i garaget ");
                Console.WriteLine("Menyval 3: Lägg till fordon ur garaget ");
                Console.WriteLine("Menyval 4: Ta bort fordon ur garaget ");
                Console.WriteLine("Menyval 5: sätt maxkapacitet för nytt garage ");
                Console.WriteLine("Menyval 6: Hitta fordon via regnr ");
                Console.WriteLine("Menyval 7: hitta fordon genom egenskap ");
                Console.WriteLine("Menyval 8: Avsluta menyval ");

                menyval = Console.ReadLine();
                switch (menyval)
                {
                    case "1":
                        Console.WriteLine("Lista på alla parkerade fordon: ");

                        var allVehicles = garagehandler.GetVehicles();
                        foreach (var v in allVehicles)
                        {
                            Console.WriteLine(v.Stats()); //Skriv ut det du vill visa
                        }
                        return;

                    case "2":
                        Console.WriteLine("Lista fordonstyper och antal av varje: ");

                        var listVehicles = garagehandler.GetVehicles();
                        foreach (var v in listVehicles)
                        {
                            Console.WriteLine(v.Stats()); //Skriv ut det du vill visa
                        }

                        return;

                    case "3":
                        Console.WriteLine("Ange regno: ");
                        Regno = Console.ReadLine();

                        Console.WriteLine("Ange fordonstyp: ");
                        VehicleType = Console.ReadLine();

                        Console.WriteLine("Ange färg: ");
                        Color = Console.ReadLine();

                        Console.WriteLine("Ange antal hjul: ");
                        bool result = int.TryParse(Console.ReadLine(), out int Wheel);

                        //var createdSuccesfully = garagehandler.CreateVehicle(Regno, VehicleType, Color, Wheel);
                        garagehandler.CreateVehicle(Regno, VehicleType, Color, Wheel);
                        break;

                    case "8":
                        Console.WriteLine("Tack för besöket, välkommen åter !");
                        return;

                    default:
                        Console.WriteLine("Felaktigt menyval");
                        return;
                }
            } while (true);
        }
    }
}
