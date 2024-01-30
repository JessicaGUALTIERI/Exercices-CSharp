using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Niveau 1
            // Consigne : Faire un tableau qui contient des prénoms et les afficher tous dans la console
            Console.WriteLine("Niveau 1 :");
            string[] prenoms = {"Cyril", "Alexandre", "Arnaud", "Axel", "Imane", "Mathias", "Jessica", "Isabelle", "Clément", "Nathan", "Fabien", "Louis", "Necati", "Alexandre", "Nadejda", "Thomas", "Florent"};

            for (int i = 0; i < prenoms.Length; i++)
            {
                Console.WriteLine(prenoms[i]);
            }

            // Niveau 2
            // Consigne : Faire une fonction qui prend en paramètre un tableau et renvoie la moyenne des valeurs
            Console.WriteLine("\nNiveau 2 :");
            float[] notes = { 20, 10.8f, 14.3f, 11.2f };
            Console.WriteLine(Moyenne(notes));

            // Niveau 3
            // Consigne : Faire un jeu sur lequel on peut déplacer un personnage sur une grille
            Console.WriteLine("\nNiveau 3 :");
            char[,] carteJeu =
            {
                { 'O', 'O', 'O', 'O', 'O', 'O'},
                { 'O', 'O', 'O', 'O', 'O', 'O'},
                { 'O', 'O', 'O', 'O', 'O', 'O'},
                { 'O', 'O', 'O', 'X', 'O', 'O'},
                { 'O', 'O', 'O', 'O', 'O', 'O'},
                { 'O', 'O', 'O', 'O', 'O', 'O'}
            };

            
            bool continuer = true;
            int coordonneesDimension0Personnage = 3;
            int coordonneesDimension1Personnage = 3;

            Console.WriteLine("Voici la carte :");
            afficherCarte(carteJeu);
            do
            {
                
                Console.WriteLine("\nListe des commandes : 'haut', 'bas', 'gauche', 'droite', 'stop'.\nVotre commande :");
                string instructions = Console.ReadLine();

                switch (instructions)
                {
                    case "haut":
                        if (coordonneesDimension0Personnage > 0)
                        {
                            carteJeu[coordonneesDimension0Personnage - 1, coordonneesDimension1Personnage] = 'X';
                            carteJeu[coordonneesDimension0Personnage, coordonneesDimension1Personnage] = 'O';
                            coordonneesDimension0Personnage -= 1;
                            Console.WriteLine("Carte après déplacement :");
                            afficherCarte(carteJeu);
                        }
                        else
                        {
                            erreurBordCarte();
                        }
                        break;

                    case "bas":
                        if (coordonneesDimension0Personnage < carteJeu.GetLength(0) - 1)
                        {
                            carteJeu[coordonneesDimension0Personnage + 1, coordonneesDimension1Personnage] = 'X';
                            carteJeu[coordonneesDimension0Personnage, coordonneesDimension1Personnage] = 'O';
                            coordonneesDimension0Personnage += 1;
                            Console.WriteLine("Carte après déplacement :");
                            afficherCarte(carteJeu);
                        }
                        else
                        {
                            erreurBordCarte();
                        }
                        break;

                    case "gauche":
                        if (coordonneesDimension1Personnage > 0)
                        {
                            carteJeu[coordonneesDimension0Personnage, coordonneesDimension1Personnage - 1] = 'X';
                            carteJeu[coordonneesDimension0Personnage, coordonneesDimension1Personnage] = 'O';
                            coordonneesDimension1Personnage -= 1;
                            Console.WriteLine("Carte après déplacement :");
                            afficherCarte(carteJeu);
                        }
                        else
                        {
                            erreurBordCarte();
                        }
                        break;

                    case "droite":
                        if (coordonneesDimension1Personnage < carteJeu.GetLength(1) - 1)
                        {
                            carteJeu[coordonneesDimension0Personnage, coordonneesDimension1Personnage + 1] = 'X';
                            carteJeu[coordonneesDimension0Personnage, coordonneesDimension1Personnage] = 'O';
                            coordonneesDimension1Personnage += 1;
                            Console.WriteLine("Carte après déplacement :");
                            afficherCarte(carteJeu);
                        }
                        else
                        {
                            erreurBordCarte();
                        }
                        break;

                    case "stop":
                        Console.WriteLine("Fin du jeu");
                        continuer = false;
                        break;

                    default:
                        Console.WriteLine("ERREUR : Commande inconnue, veuillez réessayer !");
                        break;
                }
                
            } while (continuer);

        }

        // Niveau 2
        public static float Moyenne(float[] notesTableau)
        {
            float notesTotal = 0;
            int nombreNotes = notesTableau.Length;
            for (int i = 0; i < nombreNotes; i++)
            {
                notesTotal += notesTableau[i];
            }
            return notesTotal / nombreNotes;
        }

        // Niveau 3
        public static void afficherCarte(char[,] carte)
        {
            for (int i = 0; i < carte.GetLength(0); i++)
            {
                for (int j = 0; j < carte.GetLength(1); j++)
                {
                    Console.Write(carte[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void erreurBordCarte()
        {
            Console.WriteLine("ERREUR : Vous avez atteint le bord de la carte ! Veuillez réessayer via un autre chemin !");
        }
    }
}