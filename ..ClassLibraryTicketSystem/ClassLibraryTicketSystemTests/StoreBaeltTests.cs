using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltTests
    {
        [TestMethod()]
        public void StoreBaeltTest_Weekend()
        {
            Vehicle v=new Car();
            v.Brobizz = false;
            v.Date=DateTime.Today;
            double expected = 240;

            if (v.Date.DayOfWeek == DayOfWeek.Saturday || v.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                
                expected *= 0.8;
            }

            

            StoreBaelt s = new StoreBaelt();
        

            Assert.AreEqual(expected,s.CarDiscountedPrice(v));
        }
    }
}