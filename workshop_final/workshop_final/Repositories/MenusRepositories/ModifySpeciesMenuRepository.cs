using System;
using workshop_final.Repositories;

namespace workshop_final_console.Repositories.MenusRepositories
{
	public class ModifySpeciesMenuRepository
	{
        public static string ModifySpecieInstruction = "Entrer '1' pour afficher les espèces, '2' pour créer une nouvelle espèce, '3' pour modifier une espèce, '4' pour revenir au menu principal";
        public static string ModifySpeciesTitle = "Panel des espèces";

        public static void DisplayModifySpeciesMenu()
        {
            MenuRepository.DisplayTitle(ModifySpeciesTitle);
            Console.WriteLine(ModifySpecieInstruction);
            string userChoice = MenuRepository.VerifyChoice("1", "2", "3", "4", ModifySpecieInstruction);
            ModifySpeciesNavigation(userChoice);
        }

        public static void ModifySpeciesNavigation(string choice)
        {
            if (choice == "1")
            {
                SpecieRepository.GetSpecies();
                DisplayModifySpeciesMenu();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Quel nom donner à cette nouvelle espèce ?");
                string name = Console.ReadLine();
                SpecieRepository.CreateSpecie(name);
                DisplayModifySpeciesMenu();
            }
            else if (choice == "3")
            {
                SpecieRepository.GetSpecies();
                Console.WriteLine("Quel est l'identifiant de l'espèce à modifier ?");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Quel nouveau nom donner à cette espèce ?");
                string name = Console.ReadLine();
                SpecieRepository.EditSpecie(id, name);
                DisplayModifySpeciesMenu();
            }
            else if (choice == "4")
            {
                AppMenuRepository.DisplayAppMenu();
            }
        }
    }
}

