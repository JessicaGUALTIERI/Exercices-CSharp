using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES :
            int chiffreUtilisateur;
            int chiffreMystere;
            var rand = new Random();
            int nbTentatives = 1;
            string plurielTentative = "";
            bool restart = false;
            string userRestart;
            int maxChiffreMystere;

            // LE JEU :
            do
            {
                // CHOIX DE DIFFICULTÉ
                Console.WriteLine("JUSTE PRIX\nQuel niveau de difficulté souhaitez-vous ?\n'facile', 'moyen' ou 'difficile'");
                string difficulte = Console.ReadLine();

                // VERIF SI ON A UNE DONNÉE COHÉRENTE
                while (difficulte != "facile" && difficulte != "moyen" && difficulte != "difficile")
                {
                    Console.WriteLine("\nDifficulté non reconnue. Veuillez réessayer ('facile', 'moyen' ou 'difficile' :");
                    difficulte = Console.ReadLine();
                }

                // RÉINITIALISATION DES VARIABLES POUR REPARTIR SUR UNE NOUVELLE PARTIE
                restart = false;
                nbTentatives = 1;
                // RANDOM SELON LE NIVEAU DE DIFFICULTÉS
                if (difficulte == "facile")
                {
                    chiffreMystere = rand.Next(1, 101);
                    maxChiffreMystere = 100;
                }
                else if (difficulte == "moyen")
                {
                    chiffreMystere = rand.Next(1, 1001);
                    maxChiffreMystere = 1000;
                }
                else
                {
                    chiffreMystere = rand.Next(1, 10001);
                    maxChiffreMystere = 10000;
                }
                Console.WriteLine(chiffreMystere);
                // BOUCLE DE JEU :
                do
                {
                    Console.WriteLine("\nEntrez un nombre entre 1 et " + maxChiffreMystere + ":");
                    chiffreUtilisateur = int.Parse(Console.ReadLine());
                    if (chiffreUtilisateur < 1 || chiffreUtilisateur > maxChiffreMystere)
                    {
                        Console.WriteLine("Erreur, le chiffre est en dehors de l'intervalle recherchée.");
                    }
                    else if (chiffreUtilisateur < chiffreMystere)
                    {
                        Console.WriteLine("C'est + !");
                        nbTentatives++;
                    }
                    else if (chiffreUtilisateur > chiffreMystere)
                    {
                        Console.WriteLine("C'est - !");
                        nbTentatives++;
                    }
                } while (chiffreUtilisateur != chiffreMystere);

                // POUR ACCORDER 'coup' AU PLURIEL SI BESOIN :
                if (nbTentatives > 1)
                    plurielTentative = "s";

                // AFFICHAGE DE VICTOIRE :
                Console.WriteLine("\nBRAVO : le chiffre mystère était bien : " + chiffreMystere + ", trouvé en " + nbTentatives + " coup" + plurielTentative + " !");

                // RECOMMENCER ?
                Console.WriteLine("Voulez-vous recommencer (oui/non) ?");
                userRestart = Console.ReadLine();
                // CONVERSION DE LA RÉPONSE EN BOOLÉEN POUR RELANCER LE JEU (TRUE) OU LE STOPPER (FALSE)
                if (userRestart == "oui")
                    restart = true;
                else if (userRestart == "non")
                    restart = false;

                // TANT QU'ON VEUT RECOMMENCER, ON BOUCLE
            } while (restart == true);
            
        }
    }
}