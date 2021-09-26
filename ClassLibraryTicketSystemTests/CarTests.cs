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
        [DataTestMethod]
        [DataRow("ABC123DEF")]
        [DataRow("")]
        public void LicensePlate_ThrowsException_Test(string licensePlate)
        {
            Car c = new MC();

            Assert.ThrowsException<ArgumentException>(() => c.Licenseplate= licensePlate);
        }

        [TestMethod()]
        public void PriceMethod_Test()
        {
            Car c = new MC();
            double expected = 125;

            Assert.AreEqual(expected,c.Price());
        }

        [TestMethod()]
        public void VehicleTypeMethod_Test()
        {
            Car c = new MC();
            string expected = "MC";
            Assert.AreEqual(expected,c.VehicleType());
        }
    }
}