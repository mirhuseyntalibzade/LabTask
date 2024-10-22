using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Project.Model
{
    internal class HourlyEmployee : Employee
    {
        public int HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"""
                Id: {Id}
                Name: {Name}
                Surname: {Surname}
                Age: {Age}
                Salary: {CalculateSalary()}
                """);
        }
    }
}
