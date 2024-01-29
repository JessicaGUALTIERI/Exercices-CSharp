using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Conditions :

                Niveau 1 : Demander l'âge
                La machine nous demande notre âge et selon ce qu'on répond elle nous indique un message différent

                Niveau 2 : 3 nombres croissants
                On entre 3 nombres les uns après les autres dans la machine et elle nous indique si on a bien entré des nombres dans l'ordre croissant

                Niveau 3 : Difficulté d'un boss
                On indique quel niveau de difficulté on veut pour un boss et selon la difficulté le nombre de PV du boss affiché dans la console est différent
            */

            // Niveau 1
            Console.WriteLine("Quel est votre âge ?");
            int age = int.Parse(Console.ReadLine());
            if (age > 0 && age < 18)
            {
                Console.WriteLine("Vous êtes mineur.e.");
            }
            else if (age >= 18 && age < 115)
            {
                Console.WriteLine("Vous êtes majeur.e.");
            }
            else
            {
                Console.WriteLine("Erreur, l'âge entré est incohérent.");
            }

            // Niveau 2
            Console.WriteLine("Veuillez entrer trois nombres.\nPremier nombre : ");
            int nombre1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Deuxième nombre :");
            int nombre2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Troisième nombre :");
            int nombre3 = int.Parse(Console.ReadLine());
            if (nombre1 <= nombre2 && nombre2 <= nombre3)
            {
                Console.WriteLine("Les nombres ont bien été entrés dans l'ordre croissant.");

            }
            else
            {
                Console.WriteLine("Les nombres n'ont pas été entrés dans l'ordre croissant.");
            }

            // Niveau 3
            Console.WriteLine("Veuillez entrer le niveau souhaité pour le boss : ");
            int levelBoss = int.Parse(Console.ReadLine());
            if (levelBoss > 0 && levelBoss < 5)
                Console.WriteLine("PV du boss lvl " + levelBoss + " : " + 10 + ".");
            else if (levelBoss >= 5 && levelBoss < 10)
                Console.WriteLine("PV du boss lvl " + levelBoss + " : " + 20 + ".");
            else if (levelBoss >= 10 && levelBoss < 20)
                Console.WriteLine("PV du boss lvl " + levelBoss + " : " + 50 + ".");
            else if (levelBoss >= 20 && levelBoss <= 30)
                Console.WriteLine("PV du boss lvl " + levelBoss + " : " + 100 + ".");
            else if (levelBoss > 30)
                Console.WriteLine("Le boss lvl " + levelBoss + " est trop HL pour l'instant.");
            else
                Console.WriteLine("Un niveau négatif n'existe pas.");
        }
    }
}