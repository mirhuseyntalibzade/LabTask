using AcademyManagement.Models;
using AcademyManagement.Services.Concretes;
using AcademyManagement.Services.Interfaces;

namespace AcademyManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentService studentService = new StudentService();
            //studentService.AddStudent("Insert into Students(FirstName) Values('Test')");
            //studentService.DeleteStudentById(5);
            //studentService.UpdateStudent("FirstName = 'Hello'", 1);
            studentService.ShowAllStudents();
        }
    }
}
