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

        //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //  {
        //      var sqlConnectionString = "User ID=owner;Password=cidm;Host=192.168.75.40;Port=5432;Database=owner;Pooling=true;";
        //      optionsBuilder.UseNpgsql(sqlConnectionString);
        //  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}