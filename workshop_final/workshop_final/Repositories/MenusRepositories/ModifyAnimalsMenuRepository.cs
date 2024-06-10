using System;
using workshop_final.Repositories;

namespace workshop_final_console.Repositories.MenusRepositories
{
	public class ModifyAnimalsMenuRepository
	{
        public static string ModifyAnimalsInstruction = "Entrer '1' pour modifier un animal, '2' pour ajouter un nouvel animal, '3' pour supprimer un animal, '4' pour revenir au menu principal";
        public static string ModifyAnimalsTitle = "Panel des animaux";

        public static void DisplayModifyAnimalsMenu()
        {
            MenuRepository.DisplayTitle(ModifyAnimalsTitle);
            Console.WriteLine(ModifyAnimalsInstruction);
            string userChoice = MenuRepository.VerifyChoice("1", "2", "3", "4", ModifyAnimalsInstruction);
            ModifyAnimalsNavigation(userChoice);
        }

        public static void ModifyAnimalsNavigation(string choice)
        {
            if (choice == "1")
            {
                Console.WriteLine("Quel est l'identifiant de l'animal à modifier ?");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Quel sera son nouveau nom ?");
                string newName = Console.ReadLine();
                AnimalRepository.EditAnimalName(id, newName);
                AnimalRepository.DisplayAnimal(id);
                AppMenuRepository.DisplayAppMenu();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Quel est le nom du nouvel animal ?");
                string name = Console.ReadLine();
                Console.WriteLine("Quel est l'espèce ? 'chat' 'chien' 'cheval'");
                string specie = Console.ReadLine();
                AnimalRepository.CreateAnimal(name, specie);
                AnimalRepository.GetAnimals();
                AppMenuRepository.DisplayAppMenu();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Quel est l'identifiant de l'animal à supprimer ?");
                int id = int.Parse(Console.ReadLine());
                AnimalRepository.DeleteAnimal(id);
                AnimalRepository.GetAnimals();
                AppMenuRepository.DisplayAppMenu();
            }
            else if (choice == "4")
            {
                AppMenuRepository.DisplayAppMenu();
            }
        }
    }
}

