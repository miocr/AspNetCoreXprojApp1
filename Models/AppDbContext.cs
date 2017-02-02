using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MvcApp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Computer> Computers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./appdata.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}