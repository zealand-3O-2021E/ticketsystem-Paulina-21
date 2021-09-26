using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    // Reminder: Try Niko style Testing !!!

    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceMethodTest()
        {
            Car c = new MC();
            double expected = 125;

            Assert.AreEqual(expected,c.Price());
        }

        [TestMethod()]
        public void VehicleTypeMethodTest()
        {
            Car c = new MC();
            string expected = "MC";
            Assert.AreEqual(expected,c.VehicleType());
        }
    }
}