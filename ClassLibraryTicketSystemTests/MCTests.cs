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
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            MC c = new MC();
            double expected = 125;

            Assert.AreEqual(expected, c.Price());
        }

        [TestMethod()]
        public void VehicleTest()
        {
            MC c = new MC();
            string expected = "MC";
            Assert.AreEqual(expected, c.Vehicle());
        }
    }
}