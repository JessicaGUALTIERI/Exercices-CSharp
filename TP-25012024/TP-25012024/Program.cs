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
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
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
            int nb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Deuxième nombre :");
            int nb2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Troisième nombre :");
            int nb3 = int.Parse(Console.ReadLine());
            if (nb1 <= nb2 && nb2 <= nb3)
            {
                Console.WriteLine("Les nombres ont bien été entrés dans l'ordre croissant.");

            }
            else
            {
                Console.WriteLine("Les nombres n'ont pas été entrés dans l'ordre croissant.");
            }

            // Niveau 3
            Console.WriteLine("Veuillez entrer le niveau souhaité pour le boss : ");
            int lvlBoss = int.Parse(Console.ReadLine());
            if (lvlBoss > 0 && lvlBoss < 5)
                Console.WriteLine("PV du boss lvl " + lvlBoss + " : " + 10 + ".");
            else if (lvlBoss >= 5 && lvlBoss < 10)
                Console.WriteLine("PV du boss lvl " + lvlBoss + " : " + 20 + ".");
            else if (lvlBoss >= 10 && lvlBoss < 20)
                Console.WriteLine("PV du boss lvl " + lvlBoss + " : " + 50 + ".");
            else if (lvlBoss >= 20 && lvlBoss <= 30)
                Console.WriteLine("PV du boss lvl " + lvlBoss + " : " + 100 + ".");
            else if (lvlBoss > 30)
                Console.WriteLine("Le boss lvl " + lvlBoss + " est trop HL pour l'instant.");
            else
                Console.WriteLine("Un niveau négatif n'existe pas.");
        }
    }
}