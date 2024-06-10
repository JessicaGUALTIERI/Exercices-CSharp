using System;
using workshop_final.Models;
using workshop_final.Repositories;

namespace workshop_final_console.Repositories.MenusRepositories
{
	public class BookingMenuRepository
	{
        public static string BookingInstruction = "Entrer '1' pour voir vos réservations, '2' pour réserver un animal, '3' pour arrêter la réservation d'un animal, '4' pour revenir au menu principal";
        public static string BookingTitle = "Réservation";

        public static void DisplayBookingMenu()
        {
            MenuRepository.DisplayTitle(BookingTitle);
            Console.WriteLine(BookingInstruction);
            string userChoice = MenuRepository.VerifyChoice("1", "2", "3", "4", BookingInstruction);
            BookingNavigation(userChoice);
        }

        public static void BookingNavigation(string choice)
        {
            if (choice == "1")
            {
                BookingRepository.GetMyReservations(CurrentUser.Mail);
                DisplayBookingMenu();
            }
            else if (choice == "2")
            {
                AnimalRepository.GetAnimals();
                Console.WriteLine("Quel est l'identifiant de l'animal que vous souhaitez réserver ?");
                int id = int.Parse(Console.ReadLine());
                BookingRepository.BookAnAnimal(id, CurrentUser.Mail);
                DisplayBookingMenu();
            }
            else if (choice == "3")
            {
                BookingRepository.GetMyReservations(CurrentUser.Mail);
                Console.WriteLine("Quel est l'identifiant de l'animal que vous souhaitez ramener ?");
                int id = int.Parse(Console.ReadLine());
                BookingRepository.StopBooking(id);
                DisplayBookingMenu();
            }
            else if (choice == "4")
            {
                AppMenuRepository.DisplayAppMenu();
            }
        }
    }
}

