using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
         public int PassengerId { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [Key]
        [StringLength(7)]
        public int PassportNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        //[EmailAddress]
        public string EmailAddress { get; set;}

        [MinLength(3, ErrorMessage = "longueur minimale 3 caractères")]
        [MaxLength(25, ErrorMessage = "longueur maximale 25 caractères")]
        public string FirstName { get; set;}
        
        public string LastName { get; set;}

        [RegularExpression(@"^[0-9]{8}$")]
        public string TelNumber { get; set;}

        public ICollection<Flight> Flights { get; set; }
        public Passenger() { }
        public Passenger(DateTime birthDate, int passportNumber, string emailAddress, string firstName, string lastName, string telNumber, ICollection<Flight> flights)
        {
            BirthDate = birthDate;
            PassportNumber = passportNumber;
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            TelNumber = telNumber;
            Flights = flights;
        }
        public Passenger(DateTime birthDate, int passportNumber, string emailAddress, string firstName, string lastName, string telNumber)
        {
            BirthDate = birthDate;
            PassportNumber = passportNumber;
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            TelNumber = telNumber;
            
        }


        public bool checkProfile (string firstName,string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }
        public bool checkProfile(string firstName, string lastName,string mail)
        {
            return FirstName == firstName && LastName == lastName && mail == EmailAddress;
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }

    }
}
