using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MvcApp.Models;

namespace AspNetCoreXprojApp1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170202103659_Migration3")]
    partial class Migration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("MvcApp.Models.Computer", b =>
                {
                    b.Property<int>("ComputerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Name");

                    b.Property<int?>("OwnerPersonId");

                    b.HasKey("ComputerId");

                    b.HasIndex("OwnerPersonId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("MvcApp.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.Property<string>("SurName");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("MvcApp.Models.Computer", b =>
                {
                    b.HasOne("MvcApp.Models.Person", "Owner")
                        .WithMany("Computers")
                        .HasForeignKey("OwnerPersonId");
                });
        }
    }
}
