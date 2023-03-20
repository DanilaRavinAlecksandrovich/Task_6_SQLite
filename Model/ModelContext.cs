using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_SQLite.Model
{
    public class ModelContext : DbContext
    {
        public DbSet <User> Users { get; set; }
        public DbSet <Role> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Task_6SQLite");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
