using System;
using Microsoft.EntityFrameworkCore;
using workshop_final.Models;

namespace workshop_final.Database
{
	public class AppDbContext : DbContext
	{
		public DbSet<Animal> Animals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Specie> Species { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;User ID=root;Password=root;Database=Animalz");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasData(
                    new Animal { Id = 1, SpecieId = 1, Name="Titi", IsBooked = false },
                    new Animal { Id = 2, SpecieId = 1, Name = "Marley", IsBooked = false },
                    new Animal { Id = 3, SpecieId = 1, Name = "Carlos", IsBooked = false },
                    new Animal { Id = 4, SpecieId = 2, Name = "Rex", IsBooked = false },
                    new Animal { Id = 5, SpecieId = 2, Name = "Médor", IsBooked = false },
                    new Animal { Id = 6, SpecieId = 2, Name = "Cookie", IsBooked = false },
                    new Animal { Id = 7, SpecieId = 3, Name = "Epona", IsBooked = false },
                    new Animal { Id = 8, SpecieId = 3, Name = "Éclair", IsBooked = false },
                    new Animal { Id = 9, SpecieId = 3, Name = "Tornade", IsBooked = false }
                    );

            modelBuilder.Entity<Specie>()
                .HasData(
                    new Animal { Id = 1, Name = "Chat" },
                    new Animal { Id = 2, Name = "Chien" },
                    new Animal { Id = 3, Name = "Cheval" }
                    );
        }
    }
}

