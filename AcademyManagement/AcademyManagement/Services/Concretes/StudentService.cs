using AcademyManagement.Models;
using AcademyManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AcademyManagement.Services.Concretes
{
    internal class StudentService : IStudentService
    {
        public string connectionString = "server=DESKTOP-2BVJ5J7;database=AcademyDB;Trusted_Connection=True;";

        private readonly List<Student> Students;

        public StudentService()
        {
            Students = [];
        }

        public void AddStudent(string command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Data added");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        public void DeleteStudentById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"UPDATE Students set isDeleted = 1 WHERE id = {id}", sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Student is deleted");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }


        public void UpdateStudent(string updatedColumn, int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"UPDATE Students Set {updatedColumn} where id = {id}", sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Data updated");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        public void ShowAllStudents()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Students", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    if ((bool)item["isDeleted"] == false)
                    {
                        Console.WriteLine(item["Id"] + " " + item["FirstName"]);
                    }
                }
            }
        }
    }
}
