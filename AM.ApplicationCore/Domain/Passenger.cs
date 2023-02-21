using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public string EmailAddress { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        //public bool CheckProfile(string first_name,string last_name)
        //{
        //    return first_name == FirstName && last_name == LastName;
        //}
        
        public bool CheckProfile(string first_name, string last_name,string mail = null)
        {
            if ( mail !=null )
            {
                return first_name == FirstName && last_name == LastName && mail == EmailAddress;
            }
            else
            {
                return first_name == FirstName && last_name == LastName ;
            }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("i'm Passenger !");
        }
    }
}
