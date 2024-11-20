using AcademyManagementEFProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementEFProject.Services.Abstractions
{
    internal interface IStudentService
    {
        void CreateStudent(Student student);
        Student GetStudentById(int id);
        List<Student> GetStudentsByName(string name);
        List<Student> GetAllStudents();
        List<Student> GetAllActiveStudents(); 
        List<Student> GetStudensByEnrollmentDate(int days); 
        void UpdateStudent(int id, Student student);
        void SoftDeleteStudent(int id);
        void HardDeleteStudent(int id);
    }
}
