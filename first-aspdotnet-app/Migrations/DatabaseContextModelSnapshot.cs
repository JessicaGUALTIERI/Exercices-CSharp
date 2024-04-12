﻿// <auto-generated />
using System;
using FirstAspDotnetApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstAspDotnetApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FirstAspDotnetApp.Models.Classroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("FirstAspDotnetApp.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClassroomId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FirstAspDotnetApp.Models.Student", b =>
                {
                    b.HasOne("FirstAspDotnetApp.Models.Classroom", null)
                        .WithMany("Students")
                        .HasForeignKey("ClassroomId");
                });

            modelBuilder.Entity("FirstAspDotnetApp.Models.Classroom", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
