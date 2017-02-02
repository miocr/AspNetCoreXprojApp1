using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MvcApp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./appdata.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}