using Microsoft.EntityFrameworkCore;
using Pronia_Project.Models;

namespace Pronia_Project.DAL.Contexts
{
    public class ProniaDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2BVJ5J7;Database=ProniaDB;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<SliderItem> SliderItems { get; set; }
    }
}
