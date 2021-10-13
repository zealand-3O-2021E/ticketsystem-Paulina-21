using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using StoreBaeltTicketLibrary;

namespace OresundBron.Tests
{
    [TestClass()]
    public class OresundBronTests
    {
        [TestMethod()]
        public void CarDiscountedPrice_Test()
        {
            Vehicle v = new Car();
            v.Brobizz = true;

            double expected = 161;

            OresundBron s = new OresundBron();


            Assert.AreEqual(expected, s.VehicleDiscountedPrice(v));
        }

        [TestMethod()]
        public void MCDiscountedPrice_Test()
        {
            Vehicle v = new MC();
            v.Brobizz = true;

            double expected = 73;

            OresundBron s = new OresundBron();


            Assert.AreEqual(expected, s.VehicleDiscountedPrice(v));
        }

        [TestMethod()]
        public void VehicleType_Car_Test()
        {
            Vehicle c = new Car();
            string expected = "Oresund Car";

            OresundBron s = new OresundBron();

            Assert.AreEqual(expected, s.VehicleType(c));
        }

        [TestMethod()]
        public void VehicleType_MC_Test()
        {
            Vehicle c = new MC();
            string expected = "Oresund MC";

            OresundBron s = new OresundBron();

            Assert.AreEqual(expected, s.VehicleType(c));
        }
    }
}