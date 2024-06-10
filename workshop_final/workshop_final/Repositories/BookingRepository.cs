using System;
using workshop_final.Database;
using workshop_final.Models;

namespace workshop_final.Repositories
{
	public static class BookingRepository
	{
		public static void BookAnAnimal(int id, string mail)
		{
            using (var context = new AppDbContext())
            {
                Animal animal = context.Animals.FirstOrDefault(x => x.Id == id);
                animal.IsBooked = true;
                User user = context.Users.FirstOrDefault(x => x.Mail == mail);
                Booking booking = new Booking { AnimalId = animal.Id, UserId = user.Id };
                context.Bookings.Add(booking);
                context.SaveChanges();
            }
        }

        public static void StopBooking(int id)
        {
            using (var context = new AppDbContext())
            {
                Animal animal = context.Animals.FirstOrDefault(x => x.Id == id);
                animal.IsBooked = false;
                Booking booking = context.Bookings.FirstOrDefault(x => x.AnimalId == id);
                context.Bookings.Remove(booking);
                context.SaveChanges();
            }
        }

        public static List<Booking> GetMyReservations(string mail)
        {
            List<Booking> bookings = new List<Booking>();
            using (var context = new AppDbContext())
            {
                User user = context.Users.FirstOrDefault(x => x.Mail == mail);
                bookings = context.Bookings.Where(x => x.UserId == user.Id).ToList();
                context.SaveChanges();
            }
            DisplayReservations(bookings);
            return bookings;
        }

        public static void DisplayReservations(List<Booking> bookings)
        {
            if (bookings.Count() > 0)
            {
                Console.WriteLine("----Identifiant----------Nom------");
                foreach (Booking booking in bookings)
                {
                    Animal animal = new Animal();
                    using (var context = new AppDbContext())
                    {
                        animal = context.Animals.FirstOrDefault(x => x.Id == booking.AnimalId);
                    }
                    Console.WriteLine("|\t" + animal.Id + "\t | \t" + animal.Name + "\t |");
                }
                Console.WriteLine("----------------------------------");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas de réservations en cours.");
            }
        }
    }
}

