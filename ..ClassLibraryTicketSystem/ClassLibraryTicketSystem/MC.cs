using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// MC is inheriting the Vehicle class, and overrides it with it's unique specifications. For more info and to understand this class better, check the Vehicle class
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// constructor
        /// </summary>
        public MC()
        {
            DefaultPrice = 125;
        }
        /// <summary>
        /// VehicleType is overriding the original method from Vehicle class
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }

    }
}
