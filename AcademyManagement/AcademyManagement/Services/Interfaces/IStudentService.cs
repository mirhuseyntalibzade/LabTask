using AcademyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Services.Interfaces
{
    internal interface IStudentService
    {
        public void AddStudent(string command);
        public void DeleteStudentById(int id);
        public void UpdateStudent(string updatedColumn, int id);
        public void ShowAllStudents();
    }
}
