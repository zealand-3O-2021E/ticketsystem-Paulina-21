using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// MC is inheriting the Car class, and overrides it with it's unique specifications. For more info and to understand this class better, check the Car class
    /// </summary>
    public class MC : Car
    {
        public override string VehicleType()
        {
            return "MC";
        }

        public override double Price()
        {
            return 125;
        }
    }
}
