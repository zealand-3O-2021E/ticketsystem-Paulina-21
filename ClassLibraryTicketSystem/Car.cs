using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Car Class Object with Licenseplate & Date Properties and Price and VehicleType methods
    /// </summary>
    public abstract class Car
    {
        private string _license;
        /// <summary>
        /// Property which stores the License plate number, string
        /// </summary>
        public string Licenseplate
        {
            get=>_license;
            set
            {
                if (value.Length >= 7 || value.Length<=0)
                {
                    throw new ArgumentException($"The License Plate can't have more than 7 characters and can't be null! You entered a {value.Length} characters License Plate");
                }

                _license = value;
            }
        }
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
