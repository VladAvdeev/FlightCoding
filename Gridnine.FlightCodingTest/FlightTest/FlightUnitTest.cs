using Gridnine.FlightCodingTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FlightTest
{
   
    public class FlightUnitTest
    {
        //flightTable.ShowAllFlights(flight);
            //flightTable.ShowAllFlights(flightFilter.GetFiltredFlightsArrivalMoreDeparture(flight));
            //flightTable.ShowAllFlights(flightFilter.GetFiltredFlightsMoreTwoHours(flight));
        [Fact]
        public void FlightDepartureUntilNowTest()
        {
            // Arrange
            FlightBuilder flightBuilder = new FlightBuilder();
            FlightFilter flightFilter = new FlightFilter();
            FlightTable flightTable = new FlightTable();
            IList<Flight> flight = flightBuilder.GetFlights();

            // Act
            flightTable.ShowAllFlights(flightFilter.GetFiltredFlightsDepartureUntilNow(flight));

            // Assert
            
        }
    }
}
