using AcademyManagementEFProject.Helpers;
using AcademyManagementEFProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementEFProject.Contexts
{
    internal class AcademyDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlHelper.GetConnectionString());
            base.OnConfiguring(optionsBuilder);
        }
    }
}
