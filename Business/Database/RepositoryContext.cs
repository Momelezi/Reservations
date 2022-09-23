
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
            modelBuilder.Entity<Component>()
               .HasData(
               new Component
               {
                   Id = 1,
                   Descr = "Program Delivery",
                   Active = true,
               },
               new Component
               {
                   Id = 2,
                   Descr = "TQI",
                   Active = true,
               },
               new Component
               {
                   Id = 3,
                   Descr = "ICT Integration",
                   Active = true,
               }
               );
            modelBuilder.Entity<Designation>()
               .HasData(
               new Designation
               {
                   Id = 1,
                   Descr = "SES",
                   Active = true,
               },
               new Designation
               {
                   Id = 2,
                   Descr = "CES",
                   Active = true,
               },
               new Designation
               {
                   Id = 3,
                   Descr = "DCES",
                   Active = true,
               }
               );
            modelBuilder.Entity<Directorate>()
               .HasData(
               new Directorate
               {
                   Id = 1,
                   Descr = "Ass Mngmt",
                   Active = true,
               },
               new Directorate
               {
                   Id = 2,
                   Descr = "GET",
                   Active = true,
               },
               new Directorate
               {
                   Id = 3,
                   Descr = "FET",
                   Active = true,
               }

               );
            modelBuilder.Entity<Directorate>()
               .HasData(
               new Directorate
               {
                   Id = 1,
                   Descr = "Laptop Computer",
                   Active = true,
               },
               new Directorate
               {
                   Id = 2,
                   Descr = "Data Projector",
                   Active = true,
               },
               new Directorate
               {
                   Id = 3,
                   Descr = "Whiteboard",
                   Active = true,
               }
               );
            modelBuilder.Entity<InterventionType>()
               .HasData(
               new InterventionType
               {
                   Id = 1,
                   Descr = "Laptop Computer",
                   Active = true,
               },
               new InterventionType
               {
                   Id = 1,
                   Descr = "Training",
                   Active = true,
               },
               new InterventionType
               {
                   Id = 2,
                   Descr = "Workshop",
                   Active = true,
               },
               new InterventionType
               {
                   Id = 3,
                   Descr = "Conference",
                   Active = true,
               },
               new InterventionType
               {
                   Id = 4,
                   Descr = "Seminar",
                   Active = true,
               },
               new InterventionType
               {
                   Id = 5,
                   Descr = "Meeting",
                   Active = true,
               }
               );

        }
    }
}
