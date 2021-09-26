using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC
    {
        public string Licenseplate { get; set; }
       
        public DateTime Date { get; set; }

        public double Price()
        {
            return 125;
            //The price is fixed at 125kr which must be returned
        }

        public string Vehicle()
        {
            return "MC";
            //which returns the string "MC"
        }
    }
}
