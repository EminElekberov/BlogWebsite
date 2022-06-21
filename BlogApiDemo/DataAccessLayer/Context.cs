using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-J12R9UI\\SQLEXPRESS;Database=CoreBlogApiDb;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
