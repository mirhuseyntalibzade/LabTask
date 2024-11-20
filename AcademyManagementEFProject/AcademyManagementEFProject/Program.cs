using AcademyManagementEFProject.Contexts;
using AcademyManagementEFProject.Models;
using AcademyManagementEFProject.Services.Concretes;
using Microsoft.EntityFrameworkCore;

namespace AcademyDB_EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(
                firstName: "John",
                lastName: "Doe",
                DOB: new DateTime(2000, 1, 1),
                userName: "johndoe",
                password: "securepassword",
                enrollmentDate: new DateTime(2023, 9, 1),
                createdDate: DateTime.Now,
                lastModifiedDate: null,
                deletedDate: null,  
                isDeleted: false
            );

            //StudentService studentService = new();

            //studentService.CreateStudent(student);


        }
    }
}
