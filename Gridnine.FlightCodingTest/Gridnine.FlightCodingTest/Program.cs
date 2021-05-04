using System;
using System.Collections.Generic;

namespace Gridnine.FlightCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightBuilder flightBuilder = new FlightBuilder();
            FlightFilter flightFilter = new FlightFilter();
            FlightTable flightTable = new FlightTable();
            IList<Flight> flight = flightBuilder.GetFlights();

            Console.WriteLine("Все рейсы: ");
            flightTable.ShowAllFlights(flight);

            Console.WriteLine();
            Console.WriteLine("Вылеты до текущего момента времени исключены: ");
            flightTable.ShowAllFlights(flightFilter.GetFiltredFlightsDepartureUntilNow(flight));

            Console.WriteLine();
            Console.WriteLine("Вылеты, имеющие сегменты с датой прилета раньше даты вылета исключены: ");
            flightTable.ShowAllFlights(flightFilter.GetFiltredFlightsArrivalMoreDeparture(flight));

            Console.WriteLine();
            Console.WriteLine("Вылеты со временем на земле более двух часов исключены: ");
            flightTable.ShowAllFlights(flightFilter.GetFiltredFlightsMoreTwoHours(flight));
        }
    }
}
