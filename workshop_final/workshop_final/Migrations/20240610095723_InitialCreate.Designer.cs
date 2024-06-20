﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using workshop_final.Database;

#nullable disable

namespace workshop_final.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240610095723_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("workshop_final.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SpecieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsBooked = false,
                            Name = "Titi",
                            SpecieId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsBooked = false,
                            Name = "Marley",
                            SpecieId = 1
                        },
                        new
                        {
                            Id = 3,
                            IsBooked = false,
                            Name = "Carlos",
                            SpecieId = 1
                        },
                        new
                        {
                            Id = 4,
                            IsBooked = false,
                            Name = "Rex",
                            SpecieId = 2
                        },
                        new
                        {
                            Id = 5,
                            IsBooked = false,
                            Name = "Médor",
                            SpecieId = 2
                        },
                        new
                        {
                            Id = 6,
                            IsBooked = false,
                            Name = "Cookie",
                            SpecieId = 2
                        },
                        new
                        {
                            Id = 7,
                            IsBooked = false,
                            Name = "Epona",
                            SpecieId = 3
                        },
                        new
                        {
                            Id = 8,
                            IsBooked = false,
                            Name = "Éclair",
                            SpecieId = 3
                        },
                        new
                        {
                            Id = 9,
                            IsBooked = false,
                            Name = "Tornade",
                            SpecieId = 3
                        });
                });

            modelBuilder.Entity("workshop_final.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("workshop_final.Specie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Species");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chat"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Chien"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cheval"
                        });
                });

            modelBuilder.Entity("workshop_final.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}