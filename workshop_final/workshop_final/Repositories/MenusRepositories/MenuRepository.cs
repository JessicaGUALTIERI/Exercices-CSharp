using System;
using workshop_final.Models;
using workshop_final_console.Repositories;

namespace workshop_final.Repositories
{
	public static class MenuRepository
	{
		public static string AppTitle = "APPLICATION ANIMALIZ";
		
        public static void DisplayTitle(string title)
		{
			Console.WriteLine("\n" + AppTitle + " - " + title);
		}

		public static string VerifyChoice(string choiceOne, string choiceTwo, string instruction)
		{
			string choice = Console.ReadLine();
			while (!(choice == choiceOne || choice == choiceTwo))
			{
				Console.WriteLine("Choix non reconnu, veuillez réessayer. " + instruction);
				choice = Console.ReadLine();
            }
			return choice;
		}

        public static string VerifyChoice(string choiceOne, string choiceTwo, string choiceThree, string instruction)
        {
            string choice = Console.ReadLine();
            while (!(choice == choiceOne || choice == choiceTwo || choice == choiceThree))
            {
                Console.WriteLine("Choix non reconnu, veuillez réessayer. " + instruction);
                choice = Console.ReadLine();
            }
            return choice;
        }

        public static string VerifyChoice(string choiceOne, string choiceTwo, string choiceThree, string choiceFour, string instruction)
        {
            string choice = Console.ReadLine();
            while (!(choice == choiceOne || choice == choiceTwo || choice == choiceThree || choice == choiceFour))
            {
                Console.WriteLine("Choix non reconnu, veuillez réessayer. " + instruction);
                choice = Console.ReadLine();
            }
            return choice;
        }
    }
}

