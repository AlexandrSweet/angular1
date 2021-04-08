﻿// <auto-generated />
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210331183203_ComputerEntities")]
    partial class ComputerEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccessLayer.Entities.ComputerManufacturer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ManufacturerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ComputerManufacturers");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ComputerModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ComputerManufacturerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComputerManufacturerId");

                    b.ToTable("ComputerModels");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ComputerModel", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.ComputerManufacturer", null)
                        .WithMany("Computermodels")
                        .HasForeignKey("ComputerManufacturerId");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ComputerManufacturer", b =>
                {
                    b.Navigation("Computermodels");
                });
#pragma warning restore 612, 618
        }
    }
}