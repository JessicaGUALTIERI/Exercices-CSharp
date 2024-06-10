using System;
using workshop_final;
using workshop_final.Repositories;

namespace workshop_final_console.Repositories.MenusRepositories
{
	public class StartingMenuRepository
	{
        public static string StartingInstruction = "Entrer '1' pour vous connecter, '2' pour vous inscrire";
        public static string StartingMenuTitle = "Portail de connextion";

        public static void DisplayStartingMenu()
        {
            MenuRepository.DisplayTitle(StartingMenuTitle);
            Console.WriteLine(StartingInstruction);
            string userChoice = MenuRepository.VerifyChoice("1", "2", StartingInstruction);
            StartingMenuNavigation(userChoice);
        }

        public static void StartingMenuNavigation(string choice)
        {
            if (choice == "1")
            {
                UserRepository.Login();
            }
            else if (choice == "2")
            {
                UserRepository.SignIn();
            }
        }
    }
}

