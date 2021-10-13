using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaelt
    {
        public double CarDiscountedPrice(Vehicle v)
        {
            if (v.GetType() == typeof(Car))
            {
                if (v.Date.DayOfWeek == DayOfWeek.Sunday || v.Date.DayOfWeek == DayOfWeek.Saturday)
                {
                    v.DefaultPrice *= 0.8;
                    return v.Price();
                }
            }

            return v.DefaultPrice;
        }
    }
}
