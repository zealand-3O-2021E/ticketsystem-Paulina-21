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
    public abstract class Car
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
        /// Method returning the price (double) of the Car, default 240. It's virtual because it can be override in kid classes
        /// </summary>
        /// <returns></returns>
        public virtual double Price()
        {
            return 240;//The price is fixed at 240 which must be returned
        }

        /// <summary>
        /// Method returning the Vehicle Type (string), default "Car". Virtual because it can be override in kid classes
        /// </summary>
        /// <returns></returns>
        public virtual string VehicleType()
        {
            return "Car"; //which returns the string "Car"

        }
    }
}
