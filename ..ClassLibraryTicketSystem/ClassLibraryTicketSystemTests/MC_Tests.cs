using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    // Reminder: Try Niko style Testing !!!

    [TestClass()]
    public class MC_Tests
    {
        [DataTestMethod]
        [DataRow("ABC123DEF")]
        [DataRow("")]
        public void LicensePlate_ThrowsException_Test(string licensePlate)
        {
            Vehicle c = new MC();

            Assert.ThrowsException<ArgumentException>(() => c.Licenseplate= licensePlate);
        }

        [TestMethod()]
        public void PriceMethod_BroBizz_Test()
        {
            Vehicle c = new MC();
            c.Brobizz = true;
            double expected = 95;
            expected *= 125;
            expected /= 100;

            Assert.AreEqual(expected, c.Price());
        }

        [TestMethod()]
        public void PriceMethod_Test()
        {
            Vehicle c = new MC();
            c.Brobizz = false;
            double expected = 125;

            Assert.AreEqual(expected,c.Price());
        }

        [TestMethod()]
        public void VehicleTypeMethod_Test()
        {
            Vehicle c = new MC();
            string expected = "MC";
            Assert.AreEqual(expected,c.VehicleType());
        }
    }
}