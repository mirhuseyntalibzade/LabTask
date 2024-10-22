using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Project.Model
{
    internal abstract class Employee
    {
        public static int _counter;
        public int Id { get; }

        protected Employee()
        {
            Id = _counter;
            _counter++;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public abstract double CalculateSalary();
        public abstract void DisplayDetails();
    }
}
