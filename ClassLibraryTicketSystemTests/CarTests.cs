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
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            Car c=new Car();
            double expected = 240;

            Assert.AreEqual(expected,c.Price());
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Car c = new Car();
            string expected = "Car";
            Assert.AreEqual(expected,c.VehicleType());
        }
    }
}