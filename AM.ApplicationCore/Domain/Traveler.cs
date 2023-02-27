using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveler:Passenger
    {   public string HealthInformation { get; set; }

        public string Nationality { get; set; }
        public Traveler() { }
        public Traveler(string healthInformation, string nationality)
        {
            HealthInformation = healthInformation;
            Nationality = nationality;
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a traveler");
        }
    }
}
