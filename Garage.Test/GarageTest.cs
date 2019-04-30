using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Uppgift5;


namespace Uppgift5Test
{
    [TestClass]
    public class GarageTest
    {
        private string name;
        public string Name;
        Garage<Vehicle> garage;


        [TestMethod]
        public void TestCase1()
        {

        }


        [TestMethod]
        public void CreateGarage()
        {
            garage = new Garage<Vehicle>(name, 3);
           

            
        }

        [TestMethod]
        public void FindVehicle()
        {
            //Arrange
            Garage<Vehicle> garage = new Garage<Vehicle>("New", 10);
            Car car = new Car("abc123", "Car", "Red", 4, "Gas");
            garage.Add(car);

            //Act
            var actual = garage.Find(car);

            //Assert
            Assert.AreEqual(true, actual);


        }
             
    }
}

