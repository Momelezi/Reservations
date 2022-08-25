﻿// <auto-generated />
using System;
using Business.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Business.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220825094835_DomainFix2")]
    partial class DomainFix2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessDomain.Domain.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComponentId")
                        .HasColumnType("int");

                    b.Property<int?>("DesignationId")
                        .HasColumnType("int");

                    b.Property<int?>("DirectorateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DurationEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DurationStart")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PreparationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Requestor")
                        .HasColumnType("int");

                    b.Property<int?>("ResponsibleDirector")
                        .HasColumnType("int");

                    b.Property<int>("ResponsiblePerson")
                        .HasColumnType("int");

                    b.Property<int?>("UnitManager")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("BranchId");

                    b.HasIndex("ComponentId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("DirectorateId");

                    b.HasIndex("PersonId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            BranchId = 1,
                            Active = true,
                            Description = "Computer Science"
                        },
                        new
                        {
                            BranchId = 2,
                            Active = true,
                            Description = "Chemistry"
                        });
                });

            modelBuilder.Entity("BusinessDomain.Domain.Component", b =>
                {
                    b.Property<int>("ComponentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComponentId"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComponentId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignationId"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesignationId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Directorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DirectorateId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directorates");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentId"), 1L, 1);

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipmentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("EquipmentId");

                    b.HasIndex("EquipmentCategoryId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("BusinessDomain.Domain.EquipmentBooking", b =>
                {
                    b.Property<int>("EquipmentBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentBookingId"), 1L, 1);

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.HasKey("EquipmentBookingId");

                    b.HasIndex("BookingId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("EquipmentBookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.EquipmentCategory", b =>
                {
                    b.Property<int>("EquipmentCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentCategoryId"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentCategoryId");

                    b.ToTable("EquipmentCategorys");
                });

            modelBuilder.Entity("BusinessDomain.Domain.InterventionType", b =>
                {
                    b.Property<int>("InterventionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterventionTypeId"), 1L, 1);

                    b.Property<bool>("Activity")
                        .HasColumnType("bit");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterventionTypeId");

                    b.ToTable("InterventionTypes");
                });

            modelBuilder.Entity("BusinessDomain.Domain.InterventionTypeBooking", b =>
                {
                    b.Property<int>("InterventionTypeBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterventionTypeBookingId"), 1L, 1);

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("InterventionTypeId")
                        .HasColumnType("int");

                    b.HasKey("InterventionTypeBookingId");

                    b.HasIndex("BookingId");

                    b.HasIndex("InterventionTypeId");

                    b.ToTable("InterventionTypeBookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"), 1L, 1);

                    b.Property<int>("DirectorateId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("BusinessDomain.Domain.TargetAudience", b =>
                {
                    b.Property<int>("TargetAudienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TargetAudienceId"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TargetAudienceId");

                    b.ToTable("TargetAudiences");
                });

            modelBuilder.Entity("BusinessDomain.Domain.TargetAudienceBooking", b =>
                {
                    b.Property<int>("TargetAudienceBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TargetAudienceBookingId"), 1L, 1);

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("TargetAudienceId")
                        .HasColumnType("int");

                    b.HasKey("TargetAudienceBookingId");

                    b.HasIndex("BookingId");

                    b.HasIndex("TargetAudienceId");

                    b.ToTable("TargetAudienceBookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueId"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("VenueCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("VenueRoomId")
                        .HasColumnType("int");

                    b.HasKey("VenueId");

                    b.HasIndex("VenueCategoryId");

                    b.HasIndex("VenueRoomId");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("BusinessDomain.Domain.VenueBooking", b =>
                {
                    b.Property<int>("VenueBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueBookingId"), 1L, 1);

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("VenueBookingId");

                    b.HasIndex("BookingId");

                    b.HasIndex("VenueId");

                    b.ToTable("VenueBookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.VenueCategory", b =>
                {
                    b.Property<int>("VenueCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueCategoryId"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VenueCategoryId");

                    b.ToTable("VenueCategorys");
                });

            modelBuilder.Entity("BusinessDomain.Domain.VenueRoom", b =>
                {
                    b.Property<int>("VenueRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueRoomId"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.HasKey("VenueRoomId");

                    b.ToTable("VenueRooms");
                });

            modelBuilder.Entity("DirectoratePerson", b =>
                {
                    b.Property<int>("DirectoratesId")
                        .HasColumnType("int");

                    b.Property<int>("PeoplePersonId")
                        .HasColumnType("int");

                    b.HasKey("DirectoratesId", "PeoplePersonId");

                    b.HasIndex("PeoplePersonId");

                    b.ToTable("DirectoratePerson");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Booking", b =>
                {
                    b.HasOne("BusinessDomain.Domain.Branch", "Branch")
                        .WithMany("Bookings")
                        .HasForeignKey("BranchId");

                    b.HasOne("BusinessDomain.Domain.Component", null)
                        .WithMany("Bookings")
                        .HasForeignKey("ComponentId");

                    b.HasOne("BusinessDomain.Domain.Designation", null)
                        .WithMany("Bookings")
                        .HasForeignKey("DesignationId");

                    b.HasOne("BusinessDomain.Domain.Directorate", null)
                        .WithMany("Bookings")
                        .HasForeignKey("DirectorateId");

                    b.HasOne("BusinessDomain.Domain.Person", null)
                        .WithMany("_Bookings")
                        .HasForeignKey("PersonId");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Equipment", b =>
                {
                    b.HasOne("BusinessDomain.Domain.EquipmentCategory", null)
                        .WithMany("Equipments")
                        .HasForeignKey("EquipmentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessDomain.Domain.EquipmentBooking", b =>
                {
                    b.HasOne("BusinessDomain.Domain.Booking", "Booking")
                        .WithMany("EquipmentBookings")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessDomain.Domain.Equipment", "Equipment")
                        .WithMany("EquipmentBookings")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("BusinessDomain.Domain.InterventionTypeBooking", b =>
                {
                    b.HasOne("BusinessDomain.Domain.Booking", "Booking")
                        .WithMany("InterventionTypeBookings")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessDomain.Domain.InterventionType", "InterventionType")
                        .WithMany("InterventionTypeBookings")
                        .HasForeignKey("InterventionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("InterventionType");
                });

            modelBuilder.Entity("BusinessDomain.Domain.TargetAudienceBooking", b =>
                {
                    b.HasOne("BusinessDomain.Domain.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessDomain.Domain.TargetAudience", "TargetAudience")
                        .WithMany("TargetAudienceBookings")
                        .HasForeignKey("TargetAudienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("TargetAudience");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Venue", b =>
                {
                    b.HasOne("BusinessDomain.Domain.VenueCategory", "VenueCategory")
                        .WithMany("Venues")
                        .HasForeignKey("VenueCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessDomain.Domain.VenueRoom", "VenueRoom")
                        .WithMany("_Venues")
                        .HasForeignKey("VenueRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VenueCategory");

                    b.Navigation("VenueRoom");
                });

            modelBuilder.Entity("BusinessDomain.Domain.VenueBooking", b =>
                {
                    b.HasOne("BusinessDomain.Domain.Booking", "Booking")
                        .WithMany("VenueBookings")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessDomain.Domain.Venue", "Venue")
                        .WithMany("VenueBookings")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("DirectoratePerson", b =>
                {
                    b.HasOne("BusinessDomain.Domain.Directorate", null)
                        .WithMany()
                        .HasForeignKey("DirectoratesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessDomain.Domain.Person", null)
                        .WithMany()
                        .HasForeignKey("PeoplePersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessDomain.Domain.Booking", b =>
                {
                    b.Navigation("EquipmentBookings");

                    b.Navigation("InterventionTypeBookings");

                    b.Navigation("VenueBookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Branch", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Component", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Designation", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Directorate", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Equipment", b =>
                {
                    b.Navigation("EquipmentBookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.EquipmentCategory", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("BusinessDomain.Domain.InterventionType", b =>
                {
                    b.Navigation("InterventionTypeBookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Person", b =>
                {
                    b.Navigation("_Bookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.TargetAudience", b =>
                {
                    b.Navigation("TargetAudienceBookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.Venue", b =>
                {
                    b.Navigation("VenueBookings");
                });

            modelBuilder.Entity("BusinessDomain.Domain.VenueCategory", b =>
                {
                    b.Navigation("Venues");
                });

            modelBuilder.Entity("BusinessDomain.Domain.VenueRoom", b =>
                {
                    b.Navigation("_Venues");
                });
#pragma warning restore 612, 618
        }
    }
}
