using System;
using Demo_Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_Entity
{
	public class TodoDbContext : DbContext
	{
		public DbSet<Todo> Todos { get; set; }
		public DbSet<Status> Statuses { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL("Server=localhost;User ID=root;Password=root;Database=Todo");
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Status>().HasData(new Status { Id = 1, Label = "Brouillon" });
        }
    }
}

