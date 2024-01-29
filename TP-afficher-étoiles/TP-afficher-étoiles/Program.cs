using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de lignes d'étoiles souhaitez-vous ?");
            string entreeNombreEtoilesString = Console.ReadLine();
            int entreeNombreEtoiles = int.Parse(entreeNombreEtoilesString);
            // Niveau 1
            // Consigne : afficher X lignes de 1 étoile
            // Exemple :
                // Entrée :
                    // X == 3
                // Sortie :
                    // *
                    // *
                    // *
            Console.WriteLine("\nNiveau 1 :");
            for (int i = 0; i < entreeNombreEtoiles; i++)
            {
                Console.WriteLine("*");
            }



            // Niveau 2
            // Consigne : afficher X lignes de X étoiles
            // Exemple :
                // Entrée :
                    // X == 3
                // Sortie :
                    // ***
                    // ***
                    // ***
            Console.WriteLine("\nNiveau 2 :");
            for (int i = 0; i < entreeNombreEtoiles; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            // Niveau 3
            // Consigne : afficher X lignes de nombre d'étoiles croissant (de 1 à X)
            // Exemple :
                // Entrée :
                    // X == 3
                // Sortie :
                    // *
                    // **
                    // ***
            Console.WriteLine("\nNiveau 3 :");
            string ligneEtoiles = "";
            for (int i = 0; i < entreeNombreEtoiles; i++)
            {
                ligneEtoiles += "*";
                Console.WriteLine(ligneEtoiles);
            }

            // Niveau 4
            // Consigne : afficher une pyramide de X lignes d'étoiles
            // Exemple :
                // Entrée :
                    // X == 3
                // Sortie :
                    //  **
                    // ****
                    //******
            Console.WriteLine("\nNiveau 4 :");
            for (int i = 0; i < entreeNombreEtoiles; i++)
            {
                for (int j = 0; j < (entreeNombreEtoiles * 2); j++)
                {
                    if (j > entreeNombreEtoiles-i && j <= entreeNombreEtoiles+i)
                    {
                        Console.Write("*");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }

            // Niveau 5
            // Consigne : afficher un damier de X lignes de X étoiles
            // Exemple :
                // Entrée :
                    // X == 3
                // Sortie :
                    // * *
                    //  *
                    // * *
            Console.WriteLine("\nNiveau 5 :");
            for (int i = 0; i < entreeNombreEtoiles; i++)
            {
                // Si on est sur une ligne paire :
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= entreeNombreEtoiles; j++)
                    {
                        // Si on est sur un caractère pair :
                        if (j % 2 == 0)
                        {
                            Console.Write(" ");
                        }
                        // Si on est sur un caractère impair :
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                // Si on est sur une ligne impaire :
                else
                {
                    for (int j = 1; j <= entreeNombreEtoiles; j++)
                    {
                        // Si on est sur un caractère pair :
                        if (j % 2 == 0)
                        {
                            Console.Write("*");
                        }
                        // Si on est sur un caractère impair :
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}