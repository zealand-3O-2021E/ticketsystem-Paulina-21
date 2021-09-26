using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Car Class Object with Licenseplate & Date Properties and Price and VehicleType methods
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Property which stores the License plate number, string
        /// </summary>
        public string Licenseplate { get; set; }
        /// <summary>
        /// Property which stores a Date, type DateTime
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Method returning the price (double) of the Car, default 240
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 240;
            //The price is fixed at 240 which must be returned
        }

        /// <summary>
        /// Method returning the Vehicle Type (string), default "Car"
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
            //which returns the string "Car"
        }
    }
}
