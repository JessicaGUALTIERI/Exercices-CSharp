using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * EX 1 :
            Consigne :
                Créer une fonction qui prend en paramètre des secondes et les convertit en heures, minutes, secondes.


               EX 2 :
            Consigne :
                Créer une fonction de 'cryptage' :
                    Niveau facile : convertit toutes les voyelles en 'X'
                    Niveau difficile: créer un dictionnaire pour transformer une lettre en une autre ; créer une fonction de
                                      cryptage et une fonction de décryptage.
            */
            // EX 1 :
            Console.WriteLine("Exercice 1 : conversion de secondes en heures/minutes/seconde :");
            int secondes = 24531;
            int minutes = 0;
            int heures = 0;
            Console.Write(secondes);
            ConversionSecondes(ref secondes, ref minutes, ref heures);
            Console.WriteLine("s = " + heures + "h " + minutes + "min " + secondes + "s !");

            // EX 2 :
            // Niveau facile :
            Console.WriteLine("\n\nExercice 2 (niveau facile) : cryptage d'un mot de passe où les lettres sont transformées en majuscule et les voyelles sont changées en 'X' :");
            List<char> voyelles = new List<char> { 'A', 'E', 'I', 'O', 'U', 'Y' };
            string motDePasse = "arcenciel";
            Console.WriteLine("Mot de passe avant cryptage : " + motDePasse);
            CryptageFacile(ref motDePasse, voyelles);
            Console.WriteLine("Mot de passe après cryptage : " + motDePasse);

            // Niveau difficile :
            Console.WriteLine("\nExercice 2 (niveau difficile) : cryptage et décryptage d'un mot de passe selon un dictionnaire personnalisé :");
            Dictionary<char, char> valeurCryptage = new Dictionary<char, char>();
            valeurCryptage.Add('A', 'G');
            valeurCryptage.Add('B', 'Y');
            valeurCryptage.Add('C', 'W');
            valeurCryptage.Add('D', 'I');
            valeurCryptage.Add('E', 'V');
            valeurCryptage.Add('F', 'M');
            valeurCryptage.Add('G', 'P');
            valeurCryptage.Add('H', 'B');
            valeurCryptage.Add('I', 'D');
            valeurCryptage.Add('J', 'C');
            valeurCryptage.Add('K', 'X');
            valeurCryptage.Add('L', 'Z');
            valeurCryptage.Add('M', 'E');
            valeurCryptage.Add('N', 'H');
            valeurCryptage.Add('O', 'K');
            valeurCryptage.Add('P', 'Q');
            valeurCryptage.Add('Q', 'N');
            valeurCryptage.Add('R', 'T');
            valeurCryptage.Add('S', 'F');
            valeurCryptage.Add('T', 'J');
            valeurCryptage.Add('U', 'R');
            valeurCryptage.Add('V', 'U');
            valeurCryptage.Add('W', 'L');
            valeurCryptage.Add('X', 'O');
            valeurCryptage.Add('Y', 'S');
            valeurCryptage.Add('Z', 'A');

            string motDePasse2 = "anticonstitutionnellement";
            Console.WriteLine("Mot de passe avant cryptage : " + motDePasse2);
            CryptageDifficile(ref motDePasse2, valeurCryptage);
            Console.WriteLine("Mot de passe après cryptage : " + motDePasse2);
            DecryptageDifficile(ref motDePasse2, valeurCryptage);
            Console.WriteLine("Mot de passe après décryptage : " + motDePasse2);
        }
        
        // EX 1 :
        public static void ConversionSecondes(ref int secondes, ref int minutes, ref int heures)
        {
            if (secondes >= 60)
            {
                minutes = secondes / 60;
                secondes -= minutes * 60;
            }
            if (minutes >= 60)
            {
                heures = minutes / 60;
                minutes -= heures * 60;
            }
        }
        
        // EX 2 :
        // Niveau facile
        public static void CryptageFacile(ref string motDePasse, List<char> voyelles)
        {
            motDePasse = motDePasse.ToUpper();
            char[] lettresMotDePasse = motDePasse.ToCharArray();
            for (int i = 0; i < lettresMotDePasse.Count(); i++)
            {
                foreach (char voyelle in voyelles)
                {
                    if (voyelle == lettresMotDePasse[i])
                    {
                        lettresMotDePasse[i] = 'X';
                    }
                }
            }
            motDePasse = "";
            foreach (char lettre in lettresMotDePasse)
            {
                motDePasse += lettre;
            }
        }

        // Niveau difficile :
        public static void CryptageDifficile(ref string motDePasse, Dictionary<char, char> dictionnaire)
        {
            motDePasse = motDePasse.ToUpper();
            char[] lettresMotDePasse = motDePasse.ToCharArray();
            char lettreChangee;
            for (int i = 0; i < lettresMotDePasse.Count(); i++)
            {
                if (dictionnaire.TryGetValue(lettresMotDePasse[i], out lettreChangee))
                {
                    lettresMotDePasse[i] = lettreChangee;
                }
            }
            motDePasse = "";
            foreach (char lettre in lettresMotDePasse)
            {
                motDePasse += lettre;
            }
        }

        public static void DecryptageDifficile(ref string motDePasse, Dictionary<char, char> dictionnaire)
        {
            char[] lettresMotDePasse = motDePasse.ToCharArray();
            for (int i = 0; i < lettresMotDePasse.Count(); i++)
            {
                lettresMotDePasse[i] = dictionnaire.FirstOrDefault(lettre => lettre.Value == lettresMotDePasse[i]).Key;
            }
            motDePasse = "";
            foreach (char lettre in lettresMotDePasse)
            {
                motDePasse += lettre;
            }
            motDePasse = motDePasse.ToLower();
        }
    }
}