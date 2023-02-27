using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            //List<DateTime> result = new List<DateTime>();
            //for (int i = 0; i < Flights.Count; i++)
            //{

            //    if (Flights[i].Destination == "destination")
            //      result.Add(Flights[i].FlightDate);
            //}
            throw new NotImplementedException();
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "destination":
                    foreach (var item in Flights)
                    {
                        if (item.Destination == filterValue)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var item in Flights)
                    {
                        if (item.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "departure":
                    foreach (var item in Flights)
                    {
                        if (item.Departure == filterValue)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "Flightid":
                    foreach (var item in Flights)
                    {
                        if (item.FlighID == int.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

            }
        }


        public IEnumerable<DateTime> GetFlightdates(string destination)
        {
            /*var query = from flight in Flights
                        where flight.Destination == destination
                        select flight.FlightDate;
            return query;*/
            var queryLambda = Flights.Where(f => f.Destination == destination)
                                     .Select(f => f.FlightDate);
            return queryLambda.ToList();
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            /*var query = from flight in Flights
                        where flight.FlightDate > startDate && flight.FlightDate < startDate.AddDays(7)
                        select flight;
            return query.Count();*/
            var queryLambda = Flights.Where(f => f.FlightDate >= startDate && f.FlightDate <= startDate.AddDays(7))
                                  .Count();
            return queryLambda;
        }
        public double DurationAverage(string destination)
        {
            /*var query = from flight in Flights
                        where flight.Destination == destination
                        select flight.EstimatedDuration;
            return query.Average();*/
            var queryLambda = Flights.Where((f) => f.Destination == destination)
                   .Select(f => f.EstimatedDuration);
            return queryLambda.Average();
        }

        public void ShowFlightDetails(Plane plane)
        {
            /*var query = from flight in Flights
                        where flight.Plane == plane
                        select flight;
            foreach (var item in query)
            {
                Console.WriteLine(item.FlightDate);
                Console.WriteLine(item.Destination);
            }*/
            var queryLambda = Flights.Where(f => f.Plane == plane)
               .Select(f => f);

            foreach (var item in queryLambda)
            {
                Console.WriteLine(item.FlightDate);
                Console.WriteLine(item.Destination);
            }
        }
        public Action<Plane> FlightDetailsDel;
        public Func<String, double> DurationAverageDel;
        public ServiceFlight(){
            FlightDetailsDel = plane => {
                var query = from flight in Flights
                            where flight.Plane == plane
                            select flight;
                foreach (var item in query)
                {
                    Console.WriteLine(item.FlightDate);
                    Console.WriteLine(item.Destination);
                }
            };
            DurationAverageDel = DurationAverage;
        }
    }
}
