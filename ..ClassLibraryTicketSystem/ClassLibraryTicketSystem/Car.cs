using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Car is inheriting the Vehicle class, and overrides it with it's unique specifications. For more info and to understand this class better, check the Vehicle class
    /// </summary>
    public class Car:Vehicle
    {
        /// <summary>
        /// constructor 
        /// </summary>
        public Car()
        {
            DefaultPrice = 240;
        }
        /// <summary>
        /// VehicleType is overriding the original method from Vehicle class
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
