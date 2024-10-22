using Employee_Project.Model;

namespace Employee_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.Name = "test";
            hourlyEmployee.Surname = "test";
            hourlyEmployee.HourlyRate= 30;
            hourlyEmployee.HoursWorked= 8;
            hourlyEmployee.Age= 19;
            hourlyEmployee.DisplayDetails();

        }
    }
}
