using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff :Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public string Fonction { get; set; }
        public double Salary { get; set; }
    
    public override void PassengerType()
    {
        base.PassengerType();
        Console.WriteLine("i'm a Staff !");
    }
    }
}
