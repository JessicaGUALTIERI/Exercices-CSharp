using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Consigne :
            // On est sur une machine à sous à 5€ la partie.
            // Il y a 4 symboles : cerise, banane, pomme et 7.
            // Les gains sont :
            //      2x cerise : 12€
            //      3x cerise : 20€
            //      3x banane : 30€
            //      3x pomme : 50€
            //      3x 7 : 100€
            // Il faut demander à l'utilisateur son budget et lui donner son total de gains.

            Console.WriteLine("Quel est votre budget ?");
            string budgetString = Console.ReadLine();
            int budgetDepart = int.Parse(budgetString);
            int budget = int.Parse(budgetString);
            int prixPartie = 5;
            var rand = new Random();
            int gain = 0;
            int tentative = 0;

            while (budget >= prixPartie)
            {
                budget -= prixPartie;
                int symbole1 = rand.Next(1, 5);
                int symbole2 = rand.Next(1, 5);
                int symbole3 = rand.Next(1, 5);
                // NB :
                    // cerise = 1
                    // banane = 2
                    // pomme = 3
                    // sept = 4
                if (symbole1 == 4 && symbole2 == 4 && symbole3 == 4)
                {
                    budget += 100;
                } else if (symbole1 == 3 && symbole2 == 3 && symbole3 == 3)
                {
                    budget += 50;
                } else if (symbole1 == 2 && symbole2 == 2 && symbole3 == 2)
                {
                    gain += 30;
                } else if (symbole1 == 1 && symbole2 == 1 && symbole3 == 1)
                {
                    budget += 20;
                } else if (symbole1 == 1 && symbole2 == 1 || symbole1 == 1 && symbole3 == 1 || symbole2 == 1 && symbole3 == 1)
                {
                    budget += 12;
                }
                tentative++;
            }
            Console.WriteLine("En jouant " + budgetDepart + "€, vous avez pu jouer " + tentative + " fois et vous rentrez avec " + budget + "€, soit une perte de " + (budgetDepart - budget) + "€ !");
        }
    }
}