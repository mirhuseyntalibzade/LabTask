using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string userName, string password, DateTime enrollmentDate)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            UserName = userName;
            Password = password;
            EnrollmentDate = enrollmentDate;
        }
    }
}
