using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gridnine.FlightCodingTest
{
    public class FlightFilter : IFlightFilter
    {
        public IList<Flight> GetFiltredFlightsDepartureUntilNow(IList<Flight> flights) // Правило исключения по вылету до текущего момента времени
        {
            return flights.AsParallel().Where(flight => flight.Segments.FirstOrDefault().DepartureDate > DateTime.Now).ToList(); // AsParallel - необходим в случае огромного
                                                                                                                                 // количества перелетов
        }
        public IList<Flight> GetFiltredFlightsArrivalMoreDeparture(IList<Flight> flights) // Правило исключения по имеющимся сегментам с датой прилёта раньше даты вылета
        {
            return flights.AsParallel().Where(x => !x.Segments.Where(y => y.DepartureDate > y.ArrivalDate).Any()).ToList();
        }
        public IList<Flight> GetFiltredFlightsMoreTwoHours(IList<Flight> flights) // Правило исключения по общему времени на земле более двух часов
        {
            IList<Flight> flightsWithoutMoreTwoHours = new List<Flight>();
            TimeSpan totalHour = new TimeSpan();
            foreach (Flight flight in flights)
            {
                if (flight.Segments.Count > 1)
                {
                    for (int i = 1; i < flight.Segments.Count; i++)
                    {
                        totalHour += flight.Segments[i].DepartureDate - flight.Segments[i - 1].ArrivalDate;
                    }
                    if (totalHour.Hours > 2)
                    {
                        flightsWithoutMoreTwoHours.Add(flight);
                    }
                }
            }
            return flightsWithoutMoreTwoHours;
            //return flights.AsParallel().ForAll().Where(flight => !flight.Segments.Where(time => (time.DepartureDate - time.ArrivalDate).TotalHours > 2).Any()).ToList();
        }
    }
}
