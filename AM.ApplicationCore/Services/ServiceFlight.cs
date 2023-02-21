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
            //for (int i = 0;i<Flights.Count();i++)
            //{
            //    if (Flights[i].Destination == destination)
            //    {
            //        result.Add(Flights[i].FlightDate);
            //    }
            //}
            //return result;

            //var query = from flight in Flights
            //            where flight.Destination == destination
            //            select flight.FlightDate;
            //return query.ToList();

            var queryLambda = Flights.Where(f => f.Destination == destination)
                                     .Select(f=>f.FlightDate);
            return queryLambda.ToList();
        }
        //public void GetFlightDates(string destination)
        //{
        //    //foreach (var item in Flights)
        //    //{
        //    //    if (item.Destination == destination)
        //    //    {
        //    //        Console.WriteLine(item.FlightDate);
        //    //    }
        //    //}

            
        //}

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
                        if (item.FlightID == int.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "PlaneId":
                    foreach (var item in Flights)
                    {
                        if (item.Plane.PlaneID == int.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

            }
        }

        public IEnumerable<DateTime> GetFlightdates(string destination)
        {
            //var query = from flight in Flights
            //            where flight.Destination == destination
            //            select flight.FlightDate;
            //return query;

            var queryLambda = Flights.Where(f => f.Destination == destination)
                                     .Select(f=> f.FlightDate);
            return queryLambda.ToList();
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            //var query = from flight in Flights
            //            where flight.FlightDate >= startDate && flight.FlightDate <= startDate.AddDays(7)
            //            select flight;
            //return query.Count();
            var queryLambda = Flights.Where(f=>f.FlightDate>= startDate && f.FlightDate<=startDate.AddDays(7))
                                     .Count();
            return queryLambda;
        }

        public void ShowFlightDetails(Plane plane)
        {
            //var query = from flight in Flights
            //            where flight.Plane == plane
            //            select flight;

            var queryLambda= Flights.Where(f=>f.Plane==plane)
                .Select(f=>f);

            foreach (var item in queryLambda)
            {
                Console.WriteLine(item.FlightDate);
                Console.WriteLine(item.Destination);
            }
        }
        public double DurationAverage(string destination)
        {
            //var query = from flight in Flights
            //            where flight.Destination == destination
            //            select flight.EstimatedDuration;
            //return query.Average();

            var queryLambda = Flights.Where((f)=>f.Destination==destination)
                    .Select(f=>f.EstimatedDuration);
            return queryLambda.Average();

        }
        public IEnumerable<Flight> OrderedDurationFlights()
        {
            //var query = from flight in Flights
            //            orderby flight.EstimatedDuration descending
            //            select flight;
            //return query;

            var queryLambda = Flights.OrderByDescending(f => f.EstimatedDuration);
            return queryLambda.ToList();
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            //var query = from traveler in flight.Passengers.OfType<Traveller>()
            //            orderby traveler.BirthDate
            //            select traveler;
            //return query.Take(3);

            var queryLambda = flight.Passengers.OfType<Traveller>().OrderBy(t => t.BirthDate)
                .Select(t => t);
            return queryLambda.ToList();
        }
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            //var query = from flight in Flights
            //            group flight by flight.Destination;

            var queryLambda = Flights.GroupBy(f => f.Destination)
                                     .Select(f=>f);

            foreach (var group in queryLambda)
            {
                Console.WriteLine("Destination " + group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("Decollage :" + item.FlightDate);
                }
            }
            return queryLambda;


        }
        public Action<Plane> FlightDetailsDel ;
        public Func<string,double> DurationAverageDel;
        public ServiceFlight()
        {
            //FlightDetailsDel = ShowFlightDetails;
            //DurationAverageDel = DurationAverage;
            FlightDetailsDel = p => {


                var query = from flight in Flights
                            where flight.Plane == p
                            select flight;


                foreach (var item in query)
                {
                    Console.WriteLine(item.FlightDate);
                    Console.WriteLine(item.Destination);
                }
            };
            DurationAverageDel = d => {
                var query = from flight in Flights
                            where flight.Destination == d
                            select flight.EstimatedDuration;
                return query.Average();
            };
        }
    }
}
