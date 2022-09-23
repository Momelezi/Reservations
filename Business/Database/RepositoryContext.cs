﻿
using BusinessDomain.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database
{
    public class RepositoryContext : DbContext
    {
       
       
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Directorate> Directorates { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentBooking> EquipmentBookings { get; set; }
        public DbSet<EquipmentCategory> EquipmentCategorys { get; set; }
        public DbSet<InterventionType> InterventionTypes { get; set; }
        public DbSet<InterventionTypeBooking> InterventionTypeBookings { get; set; }
        public DbSet<TargetAudience> TargetAudiences { get; set; }
        public DbSet<TargetAudienceBooking> TargetAudienceBookings { get; set; }
        public DbSet<VenueBooking> VenueBookings { get; set; }
        public DbSet<VenueCategory> VenueCategorys { get; set; }
        public DbSet<VenueRoom> VenueRooms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
            var connectionString = configuration.GetConnectionString("SqlConnection");
            optionsBuilder.UseSqlServer(connectionString);

          
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Branch>()
                .HasData(
                    new Branch
                    {
                        Id = 1,
                        Description = "Education & Planning",
                        Active = true,
                    },
                    new Branch
                    {
                        Id = 2,
                        Active = true,

                        Description = "Curriculum & Assessment Management"
                    },
                    new Branch
                    {
                        Id = 3,
                        Active = true,

                        Description = "Institutional Development"
                    },
                    new Branch
                    {
                        Id = 4,
                        Active = true,

                        Description = "Corporate Services"
                    }
                );
            modelBuilder.Entity<VenueCategory>()
                .HasData(
                new VenueCategory
                {
                    Id = 1,
                    Descr = "Auditorium",
                    Active = true,
                },
                new VenueCategory
                {
                    Id = 2,
                    Descr = "Lecture Room",
                    Active = true,
                },
                new VenueCategory
                {
                    Id = 3,
                    Descr = "Computer Lab",
                    Active = true,
                },
                new VenueCategory
                {
                    Id = 4,
                    Descr = "Boardroom",
                    Active = true,
                },
                new VenueCategory
                {
                    Id = 5,
                    Descr = "Meeting Room",
                    Active = true,
                },
                new VenueCategory
                {
                    Id = 6,
                    Descr = "Theater",
                    Active = true,
                }

                );
            modelBuilder.Entity<TargetAudience>()
                .HasData(
                new TargetAudience
                {
                    Id = 1,
                    Descr = "Foundation Phase Teachers",
                    Active = true,
                },
                new TargetAudience
                {
                    Id = 2,
                    Descr = "Circuit Principals",
                    Active = true,
                },
                new TargetAudience
                {
                    Id = 3,
                    Descr = "Subject Advisor",
                    Active = true,
                }
                );

        }
    }
}
