using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementEFProject.Helpers
{
    internal static class SqlHelper
    {
        private static readonly string _connectionString = "Server=DESKTOP-2BVJ5J7;database=NewAcademyDB;Trusted_Connection=True;TrustServerCertificate=True";

        public static string GetConnectionString() 
        {
            return _connectionString;
        }
    }
}
