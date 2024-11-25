using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class ProniaDBContext : DbContext
    {
        public ProniaDBContext(DbContextOptions options) : base(options) { }

        public DbSet<SliderItem> SliderItems { get; set; }
    }
}
