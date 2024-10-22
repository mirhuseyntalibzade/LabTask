using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Project.Model
{
    internal class SalariedEmpolyee : Employee
    {
        public int MonthlySalary {  get; set; }
        public override double CalculateSalary()
        {
            return MonthlySalary;
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
