using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Boucles :

                Niveau 1 : Afficher les chiffres de 0 à 1000 dans la console

                Niveau 2 : La machine nous demande d'entrer une lettre dans la console jusqu'à ce qu'on ait rentré la lettre a

                Niveau 3 : Idem mais jusqu'à ce qu'on ait rentré une voyelle
            */

            // Niveau 1 :
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }

            // Niveau 2 :
            string input;
            do
            {
                Console.WriteLine("Veuillez entrer la lettre 'a' :");
                input = Console.ReadLine();
            } while (input != "a");

            // Niveau 3 :
            string inputVoyelle;
            do
            {
                Console.WriteLine("Entrez une voyelle :");
                inputVoyelle = Console.ReadLine();
            } while (inputVoyelle != "a" && inputVoyelle != "e" && inputVoyelle != "i" && inputVoyelle != "o" && inputVoyelle != "u" && inputVoyelle != "y");
        }
    }
}