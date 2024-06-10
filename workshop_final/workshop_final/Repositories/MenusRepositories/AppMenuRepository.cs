using System;
using workshop_final.Models;
using workshop_final.Repositories;

namespace workshop_final_console.Repositories.MenusRepositories
{
	public class AppMenuRepository
	{
        public static string AppMenuInstruction = "Entrer '1' pour consulter la liste des animaux et accéder aux modifications, '2' pour accéder au menu de réservations, '3' pour accéder aux espèces et aux modifications, '4' pour vous déconnecter";
        public static string AppMenuTitle = "Menu de navigation";

        public static void DisplayAppMenu()
        {
            MenuRepository.DisplayTitle(AppMenuTitle);
            Console.WriteLine(AppMenuInstruction);
            string userChoice = MenuRepository.VerifyChoice("1", "2", "3", "4", AppMenuInstruction);
            AppMenuNavigation(userChoice);
        }

        public static void AppMenuNavigation(string choice)
        {
            if (choice == "1")
            {
                AnimalRepository.GetAnimals();
                ModifyAnimalsMenuRepository.DisplayModifyAnimalsMenu();
            }
            else if (choice == "2")
            {
                BookingMenuRepository.DisplayBookingMenu();
            }
            else if (choice == "3")
            {
                ModifySpeciesMenuRepository.DisplayModifySpeciesMenu();
            }
            else if (choice == "4")
            {
                CurrentUser.Mail = "";
                StartingMenuRepository.DisplayStartingMenu();
            }
        }
    }
}

