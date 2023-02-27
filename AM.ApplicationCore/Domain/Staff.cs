using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public double Salary;
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am Staff");
        }
        public Staff() { }
        public Staff(DateTime employmentDate, string function, double salary)
        {
            EmployementDate = employmentDate;
            Function = function;
            Salary = salary;
        }
    }
}
