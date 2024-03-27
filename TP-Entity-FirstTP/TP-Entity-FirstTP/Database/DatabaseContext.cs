using System;
using Microsoft.EntityFrameworkCore;
using TP_Entity_FirstTP.Models;

namespace TP_Entity_FirstTP.Database
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Animal> Animals { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;User ID=root;Password=root;Database=TP-Entity-26032024");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client { ClientId = 1, ClientNom = "Jeanne" },
                new Client { ClientId = 2, ClientNom = "Maurice" },
                new Client { ClientId = 3, ClientNom = "Lison" }
            );
            modelBuilder.Entity<Animal>().HasData(
                new Animal { AnimalId = 1, AnimalEspece = "Chat" },
                new Animal { AnimalId = 2, AnimalEspece = "Chien" },
                new Animal { AnimalId = 3, AnimalEspece = "Renard" },
                new Animal { AnimalId = 4, AnimalEspece = "Loutre" },
                new Animal { AnimalId = 5, AnimalEspece = "Poney" },
                new Animal { AnimalId = 6, AnimalEspece = "Corbeau" }
            );
            modelBuilder.Entity<Client>()
                .HasKey(t => t.ClientId);
            modelBuilder.Entity<Animal>()
                .HasKey(t => t.AnimalId);
            modelBuilder.Entity<Reservation>()
                .HasKey(t => t.ReservationId);
        }
    }
}

