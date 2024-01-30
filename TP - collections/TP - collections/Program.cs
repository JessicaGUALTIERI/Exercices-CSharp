using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Niveau 1
            // Consigne : Faire une liste qui représente des personnes dans un canal vocal, ajouter quelques personnes et afficher tout le monde. On peut ensuite retirer une personne et réafficher la nouvelle liste
            Console.WriteLine("Niveau 1 :");
            List<string> channelVocal = new List<string> { "Gaiarmonie", "Tiank", "PADU"};
            rejoindreChannelVocal(channelVocal, "Jessixica");
            afficherChannelVocal(channelVocal);

            Console.WriteLine();

            quitterChannelVocal(channelVocal, "Jessixica");
            afficherChannelVocal(channelVocal);

            // Niveau 2
            // Consigne : Faire deux listes une de noms, une de prenoms, puis faire un generateur qui associe un nom et un prenom de manière aleatoire
            Console.WriteLine("\nNiveau 2 :");
            List<string> prenoms = new List<string> { "Harry", "Hermione", "Ron", "Albus", "Severus", "Drago" };
            List<string> noms = new List<string> { "Potter", "Granger", "Weasley", "Dumbledore", "Rogue", "Malfoy" };
            Random random = new Random();
            int indexRandomPrenom = random.Next(0, prenoms.Count());
            int indexRandomNom = random.Next(0, noms.Count());
            string identiteGeneree = prenoms[indexRandomPrenom] + " " + noms[indexRandomNom];
            Console.WriteLine(identiteGeneree);

            // Niveau 3
            // Consigne : Faire un (ou plusieurs) dictionnaire qui prend comme clé un mot dans une langue et en valeur ce même mot dans une autre langue. 
            Console.WriteLine("\nNiveau 3 :");
            Dictionary<string, string> dictionnaireFrancaisAnglais = new Dictionary<string, string>();
            dictionnaireFrancaisAnglais.Add("janvier", "january");
            dictionnaireFrancaisAnglais.Add("février", "february");
            dictionnaireFrancaisAnglais.Add("mars", "march");
            dictionnaireFrancaisAnglais.Add("avril", "april");
            dictionnaireFrancaisAnglais.Add("mai", "may");
            dictionnaireFrancaisAnglais.Add("juin", "june");
            dictionnaireFrancaisAnglais.Add("juillet", "july");
            dictionnaireFrancaisAnglais.Add("août", "august");
            dictionnaireFrancaisAnglais.Add("septembre", "september");
            dictionnaireFrancaisAnglais.Add("octobre", "october");
            dictionnaireFrancaisAnglais.Add("novembre", "november");
            dictionnaireFrancaisAnglais.Add("décembre", "december");

            // Niveau 3.5 :
            // Consigne : Faire une fonction qui prend en paramètre un de ces dictionnaire ainsi qu'un mot et qui renvoie ce mot traduit par ce dictionnaire (si on lui passe "Hello" et un dictionnaire Anglais-Français, ça renvoie "Bonjour") 
            Console.WriteLine("\nNiveau 3.5 :");
            traductionFrancaisAnglais(dictionnaireFrancaisAnglais, "août");
        }

        // Niveau 1
        public static void rejoindreChannelVocal(List<string> liste, string pseudo)
        {
            liste.Add(pseudo);
        }

        public static void quitterChannelVocal(List<string> liste, string pseudo)
        {
            liste.Remove(pseudo);
        }

        public static void afficherChannelVocal(List<string> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
        }

        // Niveau 3.5 :
        public static void traductionFrancaisAnglais(Dictionary<string, string> dictionnaire, string motFrancais)
        {
            Console.WriteLine("FR : " + motFrancais + " | EN : " + dictionnaire[motFrancais]);
        }
    }
}