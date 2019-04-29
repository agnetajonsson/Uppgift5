using System;
using System.Collections;
using System.Collections.Generic;

namespace Uppgift5
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
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

        private T[] vehicles;
        public Garage(string name, int capacity)
        {
            Name = name;
            Capacity = Math.Max(0, capacity);
            vehicles = new T[capacity];
        }

        public int Capacity { get; }
        public int Count { get; private set; }
     
        public bool IsFull => Capacity <= Count;
        public bool Add(T vehicle)
        {
            if (vehicle == null) return false;

            if (IsFull) return false;
            //Todo: Logic here..... Tips for loop
            //vehicles[i]
            //platsen tom = null

            for (int i = 0; i < Capacity; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }
            return false;
        }
        public bool Remove(T vehicle)
        {
            //Hitta fordonet och ta bort det!
            return true;
        }

      
      
        public IEnumerator<T> GetEnumerator()
        {
            //ToDo Implement logic...
            //Hitta alla fordon i vehicles arrayen som inte är null och yield return på dessa!
           foreach (var vehicle in vehicles)

            {
                if (vehicle != null)
                   yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}