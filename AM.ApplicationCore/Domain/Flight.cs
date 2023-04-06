using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
      
        public int FlightId { get; set; }

        public string Destination { get; set; }
        public string Departure { get; set; }

        public DateTime FlightDate { get; set;}

        public DateTime EffectiveArrival { get; set; }

        public int EstimatedDuration { get; set; }
        public int FlighID { get; set; }

        public Plane Plane { get; set; }

        public string AirlineLogo{ get; set; }

        [ForeignKey("Plane")]
        public int PlaneFK { get; set; }

        public ICollection<Passenger> Passengers { get; set; }

        public override string ToString()
        {
            return this.Destination+" "+this.Departure;
        }   
        public Flight() { }
        public Flight(string destination, string departure, DateTime flightDate, DateTime effectiveArrival, int estimatedDuration, int flighID, Plane plane, ICollection<Passenger> passengers)
        {
            Destination = destination;
            Departure = departure;
            FlightDate = flightDate;
            EffectiveArrival = effectiveArrival;
            EstimatedDuration = estimatedDuration;
            FlighID = flighID;
            Plane = plane;
            Passengers = passengers;
        }
        public Flight(string destination, string departure, DateTime flightDate, DateTime effectiveArrival, int estimatedDuration, int flighID, Plane plane)
        {
            Destination = destination;
            Departure = departure;
            FlightDate = flightDate;
            EffectiveArrival = effectiveArrival;
            EstimatedDuration = estimatedDuration;
            FlighID = flighID;
            Plane = plane;
           
        }
    }
}
