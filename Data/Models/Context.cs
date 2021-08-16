using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Food; integrated security=true;");
        }
        public DbSet<Food> foods { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Admin> admins { get; set; }

    }
}
