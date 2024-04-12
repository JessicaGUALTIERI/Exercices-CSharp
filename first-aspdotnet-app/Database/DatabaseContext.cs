using System;
using FirstAspDotnetApp.Models;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;

namespace FirstAspDotnetApp.Database
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Classroom> Classrooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;User ID = root; Password = root; Database = FirstAppDotnet");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Classroom>()
                .HasKey(t => t.Id);
        }
    }
}

