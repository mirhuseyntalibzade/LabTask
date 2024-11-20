using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementEFProject.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Student(string firstName, string lastName, DateTime DOB, string userName, string password, DateTime enrollmentDate, DateTime createdDate, DateTime? lastModifiedDate, DateTime? deletedDate, bool isDeleted)
        {
            FirstName = firstName;
            LastName = lastName;
            this.DOB = DOB;
            UserName = userName;
            Password = password;
            EnrollmentDate = enrollmentDate;
            CreatedDate = createdDate;
            LastModifiedDate = lastModifiedDate;
            DeletedDate = deletedDate;
            IsDeleted = isDeleted;
        }
    }
}
