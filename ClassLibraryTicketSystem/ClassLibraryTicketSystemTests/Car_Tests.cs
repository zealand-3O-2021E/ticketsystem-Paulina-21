using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class Car_Tests
    {
        [TestMethod()]
        public void PriceTest()
        {
           Vehicle c = new Car();
            double expected = 240;

            Assert.AreEqual(expected, c.Price());
        }

        [TestMethod()]
        public void VehicleTest()
        {
            Vehicle c = new Car();
            string expected = "Car";
            Assert.AreEqual(expected, c.VehicleType());
        }
    }
}