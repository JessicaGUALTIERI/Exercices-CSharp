using System;
using TP_juste_prix;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES :
            int chiffreUtilisateur;
            int chiffreMystere;
            Random random = new Random();
            int nombreTentatives = 1;
            string plurielTentative = "";
            bool recommencer = false;
            string reponseUtilisateurRecommencer;
            int maximumChiffreMystere;

            Database.Initialize();

            Console.WriteLine("JUSTE PRIX\nEntrez votre pseudo :");
            string pseudo = Console.ReadLine();
            Player player = new Player { Name = pseudo, PlayerScore = new List<int>() };
            // LE JEU :
            do
            {
                // CHOIX DE DIFFICULTÉ
                Console.WriteLine("Quel niveau de difficulté souhaitez-vous ?\n'facile', 'moyen' ou 'difficile'");
                string difficulte = Console.ReadLine();

                // VERIF SI ON A UNE DONNÉE COHÉRENTE
                while (difficulte != "facile" && difficulte != "moyen" && difficulte != "difficile")
                {
                    Console.WriteLine("\nDifficulté non reconnue. Veuillez réessayer ('facile', 'moyen' ou 'difficile' :");
                    difficulte = Console.ReadLine();
                }

                // RÉINITIALISATION DES VARIABLES POUR REPARTIR SUR UNE NOUVELLE PARTIE
                recommencer = false;
                nombreTentatives = 1;
                // RANDOM SELON LE NIVEAU DE DIFFICULTÉS
                if (difficulte == "facile")
                {
                    chiffreMystere = random.Next(1, 101);
                    maximumChiffreMystere = 100;
                }
                else if (difficulte == "moyen")
                {
                    chiffreMystere = random.Next(1, 1001);
                    maximumChiffreMystere = 1000;
                }
                else
                {
                    chiffreMystere = random.Next(1, 10001);
                    maximumChiffreMystere = 10000;
                }
                Console.WriteLine(chiffreMystere);
                // BOUCLE DE JEU :
                do
                {
                    Console.WriteLine("\nEntrez un nombre entre 1 et " + maximumChiffreMystere + ":");
                    chiffreUtilisateur = int.Parse(Console.ReadLine());
                    if (chiffreUtilisateur < 1 || chiffreUtilisateur > maximumChiffreMystere)
                    {
                        Console.WriteLine("Erreur, le chiffre est en dehors de l'intervalle recherchée.");
                    }
                    else if (chiffreUtilisateur < chiffreMystere)
                    {
                        Console.WriteLine("C'est + !");
                        nombreTentatives++;
                    }
                    else if (chiffreUtilisateur > chiffreMystere)
                    {
                        Console.WriteLine("C'est - !");
                        nombreTentatives++;
                    }
                } while (chiffreUtilisateur != chiffreMystere);

                // POUR ACCORDER 'coup' AU PLURIEL SI BESOIN :
                if (nombreTentatives > 1)
                    plurielTentative = "s";

                // AFFICHAGE DE VICTOIRE :
                Console.WriteLine("\nBRAVO : le chiffre mystère était bien : " + chiffreMystere + ", trouvé en " + nombreTentatives + " coup" + plurielTentative + " !");
                player.PlayerScore.Add(nombreTentatives);
                player
                // RECOMMENCER ?
                Console.WriteLine("Voulez-vous recommencer (oui/non) ?");
                reponseUtilisateurRecommencer = Console.ReadLine();
                // CONVERSION DE LA RÉPONSE EN BOOLÉEN POUR RELANCER LE JEU (TRUE) OU LE STOPPER (FALSE)
                if (reponseUtilisateurRecommencer == "oui")
                    recommencer = true;
                else if (reponseUtilisateurRecommencer == "non")
                    recommencer = false;

                // TANT QU'ON VEUT RECOMMENCER, ON BOUCLE
            } while (recommencer == true);
            Database.DisplayDatabase();
        }
    }
}