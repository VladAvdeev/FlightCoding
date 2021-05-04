using System;
using System.Collections.Generic;
using System.Text;

namespace Gridnine.FlightCodingTest
{
    public class FlightTable
    {
        public void ShowAllFlights(IList<Flight> flights)
        {
            int i = 1;
            foreach (Flight flight in flights)
            {
                foreach(Segment segment in flight.Segments)
                {
                    Console.WriteLine($"{i}) {segment.DepartureDate} -- {segment.ArrivalDate}");
                    i++;
                }
            }
        }
    }
}
