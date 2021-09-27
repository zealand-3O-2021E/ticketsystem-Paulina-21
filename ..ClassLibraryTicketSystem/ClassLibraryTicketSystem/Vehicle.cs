using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Vehicle is a parent class, it's an abstract class
    /// </summary>
   public abstract class Vehicle
    {
        /// <summary>
        /// Vehicle Class Object with Licenseplate and Date Properties and Price and VehicleType methods
        /// </summary>
        private string _license;

            /// <summary>
            /// Value indicating if the Brobizz is used.
            /// Default false
            /// </summary>
            public bool Brobizz = false;

            /// <summary>
            /// This is a constructor
            /// </summary>
            public Vehicle()
            {
                DefaultPrice = 240;
            }

            /// <summary>
            /// Property which stores the default Price, before any discounts
            /// </summary>
            public double DefaultPrice { get; set; }

            /// <summary>
            /// Property which stores the License plate number, string
            /// </summary>
            public string Licenseplate
            {
                get => _license;
                set
                {
                    if (value.Length >= 7 || value.Length <= 0)
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
            public double Price()
            {
                double _price = DefaultPrice;
                if (Brobizz)
                {
                    _price /= 100;
                    _price *= 95;
                    return _price;
                }
                else return DefaultPrice;
            }

            /// <summary>
            /// Method returning the Vehicle Type (string), default "Car". Virtual because it can be override in kid classes
            /// </summary>
            /// <returns></returns>
            public virtual string VehicleType()
            {
                return "Vehicle"; //which returns the string "Car"

            }
        }
}
