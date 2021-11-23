using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBron
{
   public class OresundMC:Vehicle
    {
        private Vehicle mc;

        public OresundMC(Vehicle v)
        {
            mc = v;
        }
        public override double DefaultPrice { get; set; }
        public override double Price()
        {
            DefaultPrice = 210;
            if (mc.Brobizz)
                DefaultPrice = 73;
            return DefaultPrice;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
