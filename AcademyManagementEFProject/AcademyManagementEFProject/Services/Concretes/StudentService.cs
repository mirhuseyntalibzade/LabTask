using AcademyManagementEFProject.Contexts;
using AcademyManagementEFProject.Models;
using AcademyManagementEFProject.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementEFProject.Services.Concretes
{
    internal class StudentService : IStudentService
    {
        AcademyDBContext studentContext = new();
        public void CreateStudent(Student student)
        {
            studentContext.Add(student);
            int result = studentContext.SaveChanges();
            if (result == 0)
            {
                throw new Exception("Student cannot be added due to an error.");
            }
            else
            {
                Console.WriteLine("Student added successfully");
            }
        }

        public List<Student> GetAllActiveStudents()
        {
            List<Student> students = studentContext.Students.FromSql($"SELECT * FROM dbo.Students").ToList();
            List<Student> activeStudents = [];
            foreach (Student student in students)
            {
                if (!student.IsDeleted)
                {
                    activeStudents.Add(student);
                }
            }
            return activeStudents;
        }

        public List<Student> GetAllStudents()
        {
            return studentContext.Students.FromSql($"SELECT * FROM dbo.Students").ToList();
        }

        public List<Student> GetStudensByEnrollmentDate(int days)
        {
            List<Student> students = studentContext.Students.FromSql($"SELECT * FROM dbo.Students").ToList();
            //foreach (var item in students)
            //{
            //    TimeSpan dateDiff = DateTime.Now() - days
            //    if (TimeSpan )
            //    {
                    
            //    }
            //}

            return default;
        }

        public Student GetStudentById(int id)
        {
            return studentContext.Students.FirstOrDefault(student => student.Id == id);
        }

        public List<Student> GetStudentsByName(string name)
        {
            return studentContext.Students.FromSql($"SELECT * FROM dbo.Students WHERE Firstname = '{name}'").ToList();
        }

        public void HardDeleteStudent(int id)
        {
            Student student = studentContext.Students.FirstOrDefault(student => student.Id == id);
            if (student != null)
            {
                studentContext.Students.Remove(student);
                studentContext.SaveChanges();
                Console.WriteLine("Student successfully deleted.");
            } else
            {
                throw new Exception("There was an error while deleting student.");
            }
        }

        public void SoftDeleteStudent(int id)
        {
            Student student = studentContext.Students.FirstOrDefault(student => student.Id == id);
            if (student != null)
            {
                student.IsDeleted = true;
                student.DeletedDate = DateTime.Now;
                studentContext.SaveChanges();
            }
        }

        public void UpdateStudent(int id, Student student)
        {
            Student existingStudent = studentContext.Students.FirstOrDefault(s => s.Id == id);
            if (existingStudent != null)
            {
                existingStudent.FirstName = student.FirstName;
                existingStudent.LastName = student.LastName;
                existingStudent.DOB = student.DOB;
                existingStudent.UserName = student.UserName;
                existingStudent.Password = student.Password;
                existingStudent.EnrollmentDate = student.EnrollmentDate;
                existingStudent.LastModifiedDate = DateTime.Now;
                existingStudent.DeletedDate = student.DeletedDate;
                existingStudent.IsDeleted = student.IsDeleted;
                
                studentContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
