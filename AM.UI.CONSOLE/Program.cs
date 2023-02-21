using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        ////Plane p1= new Plane();
        ////p1.Capacity = 200;
        ////p1.PlaneID = 1;
        ////p1.ManufactureDate = new DateTime(2023, 02, 02);
        ////p1.PlaneType = PlaneType.Boing;
        ////Plane p2 = new Plane(PlaneType.Airbus,200,DateTime.Now) ;
        //Plane p3 = new Plane()
        //{
        //    PlaneType = PlaneType.Airbus,
        //    Capacity= 100,
        //    ManufactureDate=DateTime.Now,
        //};
        //Passenger passenger = new Passenger()
        //{
        //    FirstName = "Steve",
        //    LastName = "Foxx",
        //    EmailAddress = "boxingUK@gmail.com",
        //};
        //Console.WriteLine(passenger.CheckProfile("Steve", "Foxx", "boxingUK@gmail.com"));
        //Traveller traveller = new Traveller()
        //{
        //    FirstName="Touhemi",
        //    LastName="Toukebri",
        //    EmailAddress = "boxingUK@gmail.com",
        //    HealthInformation = "Gucci",
        //    Nationality="Disney"
        //};
        //Staff staff = new Staff()
        //{
        //    FirstName = "Miguel",
        //    LastName = "Foxx",
        //    EmailAddress = "boxingUK@gmail.com",
        //};
        //Console.WriteLine("uno");
        //staff.PassengerType();
        //Console.WriteLine("duo");
        //traveller.PassengerType();
        //Console.WriteLine("trio");
        //passenger.PassengerType();

        ServiceFlight serviceFlight = new ServiceFlight();
        serviceFlight.Flights = TestData.listFlights;
        //foreach (var item in serviceFlight.GetFlightDates("Paris"))
        //serviceFlight.DestinationGroupedFlights();
        //serviceFlight.FlightDetailsDel(TestData.BoingPlane);
        //Console.WriteLine( serviceFlight.DurationAverageDel("Paris"));

        Passenger passenger= new Passenger{
            FirstName="racem",
            LastName="b.a"
        };
        Console.WriteLine(passenger.FirstName + " " + passenger.LastName);
        passenger.UpperFullName();
        Console.WriteLine(passenger.FirstName + " " + passenger.LastName);
    }
}