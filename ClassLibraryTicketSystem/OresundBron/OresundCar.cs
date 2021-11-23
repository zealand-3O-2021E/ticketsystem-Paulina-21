using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBron
{
    public class OresundCar:Vehicle
    {
        private Vehicle car;

        public OresundCar(Vehicle v)
        {
            car = v;
        }
        public override double DefaultPrice { get; set; }
        public override double Price()
        {
            DefaultPrice = 410;
            if (car.Brobizz)
                DefaultPrice = 161;
            return DefaultPrice;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }

}
