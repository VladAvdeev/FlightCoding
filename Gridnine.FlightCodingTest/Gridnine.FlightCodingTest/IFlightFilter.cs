using System;
using System.Collections.Generic;
using System.Text;

namespace Gridnine.FlightCodingTest
{
    interface IFlightFilter
    {
        IList<Flight> GetFiltredFlightsDepartureUntilNow(IList<Flight> flights);
        IList<Flight> GetFiltredFlightsArrivalMoreDeparture(IList<Flight> flights);
        IList<Flight> GetFiltredFlightsMoreTwoHours(IList<Flight> flights);
    }
}
