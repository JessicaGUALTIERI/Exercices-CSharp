using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Niveau 1 : Dire bonjour
            La machine nous demande "comment tu t'appelles ?", on lui indique notre prénom et elle répond "Bonjour [insérer ici notre prénom]"

            Niveau 2 : Addition
            On entre deux nombres dans la machine et elle nous indique la somme de ces deux nombres

            Niveau 3 : Soldes
            On indique un prix et un pourcentage de réduction à la machine et elle nous indique le nouveau prix (par exemple un objet coûtant 100€ étant à 20% de réduction coûte au final 80€)

            Niveau 4 : Inversion
            On indique 2 valeurs et on alterne, sans passer par une 3ème variable
            */

            // Niveau 1
            Console.WriteLine("Comment tu t'appelles ?");
            string prenom = Console.ReadLine();
            Console.WriteLine("Bonjour " + prenom + " !");

            // Niveau 2
            Console.WriteLine("\nNous allons aditionner deux nombes.\nVeuillez entrer le premier nombre :");
            string nb1string = Console.ReadLine();
            int nb1 = int.Parse(nb1string);
            Console.WriteLine("Veuillez entrer le second nombre :");
            string nb2string = Console.ReadLine();
            int nb2 = int.Parse(nb2string);
            Console.WriteLine("Le résultat de " + nb1 + " + " + nb2 + " est : " + (nb1 + nb2));

            // Niveau 3
            Console.WriteLine("\nEntrez un prix (en €) :");
            string prixString = Console.ReadLine();
            int prix = int.Parse(prixString);
            Console.WriteLine("Entrez la réduction (en %) :");
            string reductionString = Console.ReadLine();
            float reduction = float.Parse(reductionString);
            float prixReduit = prix * (1 - (reduction / 100));
            Console.WriteLine("Prix sans réduction : " + prix + "€ | Prix avec réduction de " + reductionString + "% : " + prixReduit + "€");

            // Niveau 4
            Console.WriteLine("\nEntrez une première valeur :");
            string val1string = Console.ReadLine();
            int val1 = int.Parse(val1string);
            Console.WriteLine("\nEntrez une seconde valeur :");
            string val2string = Console.ReadLine();
            int val2 = int.Parse(val2string);
            Console.WriteLine("AVANT INVERSION : valeur1 = " + val1 + " valeur2 = " + val2);
            val1 += val2;
            val2 = val1 - val2;
            val1 -= val2;
            Console.WriteLine("APRÈS INVERSION : valeur1 = " + val1 + " valeur2 = " + val2);
        }
    }
}


