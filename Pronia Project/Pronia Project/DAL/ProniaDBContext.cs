using Microsoft.EntityFrameworkCore;
using Pronia_Project.Models;

namespace Pronia_Project.DAL
{
    public class ProniaDBContext : DbContext
    {
        public ProniaDBContext(DbContextOptions options) : base(options) { }
        public DbSet<SliderItem> SliderItems { get; set; }
    }
}
