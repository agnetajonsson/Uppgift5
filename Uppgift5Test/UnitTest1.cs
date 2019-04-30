using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Uppgift5;


namespace Uppgift5Test
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            Vehicle fp = new Vehicle();
            bool fromCall;

            fromCall = fp.FileExist(@"C:\Windows\Regedit.exe");
           
            Assert.IsTrue(fromCall);
        }
        public void FileNameDoesNotExist()
        {
            VehicleTest fp = new VehicleTest();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\BadFileName.bad");
            Assert.IsFalse(fromCall);
        }
        public void FileNameNullOrEmpty_ThrowsArgumentNullExceptio()
        {
            VehicleTest fp = new VehicleTest();
            fp.FileExists("");
        }
    }
}
