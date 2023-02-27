// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;


ServiceFlight serviceFlight= new ServiceFlight();
serviceFlight.Flights = TestData.listFlights;
//serviceFlight.GetFlights("destination", "Paris");
//Console.WriteLine(serviceFlight.DurationAverageDel("Paris"));
//serviceFlight.FlightDetailsDel(TestData.BoingPlane);
PqssengerExtension.UpperFullName(TestData.traveller1);
Console.WriteLine(TestData.traveller1.FirstName+' '+TestData.traveller1.LastName);