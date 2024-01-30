using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // Niveau 1
        // Consigne : créer une fonction de calcul de l'aire d'un rectangle
        public static int AireRectangle(int largeur, int longueur)
        {
            return largeur * longueur;
        }

        // Niveau 2
        // Consigne : créer une fonction qui affichera X fois quelque chose
        public static void AfficherXfois(int nombreDeFois, string contenu)
        {
            for (int i = 0; i < nombreDeFois; i++)
            {
                Console.WriteLine(contenu);
            }
        }

        // Niveau 3
        // Consigne : créer une fonction
        public static int CalculExposant(int nombreBase, int nombreExposant)
        {
            int result = nombreBase;
            for (int i = 1; i < nombreExposant; i++) // Démarre à 1 car on a déjà fait 1x en assignant nombreBase à result
            {
                result *= nombreBase;
            }
            return result;
        }
        

        static void Main(string[] args)
        {
            // Niveau 1
            int rectangle = AireRectangle(2, 5);
            Console.WriteLine(rectangle);

            // Niveau 2
            AfficherXfois(5, "Hodor");

            // Niveau 3
            int calcul2Puissance10 = CalculExposant(2, 10);
            Console.WriteLine(calcul2Puissance10);
            int calcul5Puissance3 = CalculExposant(5, 3);
            Console.WriteLine(calcul5Puissance3);
        }
    }
}

