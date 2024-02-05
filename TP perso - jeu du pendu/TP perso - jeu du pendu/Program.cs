using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||Jeu du pendu||");

            string[] words =
            {
                "CHIEN",
                "CHAT",
                "OISEAU",
                "LION",
                "ELEPHANT",
                "SERPENT",
                "DAUPHIN",
                "KANGOUROU",
                "PAPILLON",
                "GIRAFE",
                "CHEVAL",
                "SINGE",
                "TIGRE",
                "POISSON",
                "HIPPOPOTAME",
                "ARAIGNEE",
                "COCCINELLE",
                "PANDA",
                "CROCODILE",
                "LOUTRE",
                "ORDINATEUR",
                "TELEPHONE",
                "LAMPE",
                "STYLO",
                "CAHIER",
                "MONTRE",
                "TASSE",
                "CHAISE",
                "TABLE",
                "PARAPLUIE",
                "PORTEFEUILLE",
                "TELEVISION",
                "CASQUE",
                "LUNETTES",
                "CLAVIER",
                "SOURIS",
                "CHARGEUR",
                "JOYEUX",
                "CALME",
                "RAPIDE",
                "SILENCIEUX",
                "BRILLANT",
                "SOMBRE",
                "CHAUD",
                "FROID",
                "PETIT",
                "GRAND",
                "RAPIDE",
                "LENT",
                "COLORE",
                "PALE",
                "HEUREUX",
                "TRISTE",
                "DOUX",
                "DUR",
                "AGREABLE",
                "DESAGREABLE",
                "CHEMISE",
                "PANTALON",
                "ROBE",
                "CHAUSSURES",
                "CHAPEAU",
                "VESTE",
                "JUPE",
                "PULL",
                "CRAVATE",
                "BOTTES",
                "ECHARPE",
                "GANTS",
                "COLLANTS",
                "SHORT",
                "CHEMISIER",
                "COSTUME",
                "BLOUSE",
                "CEINTURE",
                "BONNET",
                "MANTEAU",
                "MATHEMATIQUES",
                "FRANCAIS",
                "HISTOIRE",
                "GEOGRAPHIE",
                "SCIENCES",
                "PHYSIQUE",
                "CHIMIE",
                "BIOLOGIE",
                "INFORMATIQUE",
                "ANGLAIS",
                "ESPAGNOL",
                "PHILOSOPHIE",
                "MUSIQUE",
                "ECONOMIE",
                "SOCIOLOGIE",
                "PSYCHOLOGIE",
                "LITTERATURE",
                "ETHIQUE",
                "FRANCE",
                "ALLEMAGNE",
                "JAPON",
                "CANADA",
                "AUSTRALIE",
                "BRESIL",
                "CHINE",
                "INDE",
                "ETATS-UNIS",
                "ROYAUME-UNI",
                "ITALIE",
                "ESPAGNE",
                "MEXIQUE",
                "RUSSIE",
                "AFRIQUE DU SUD",
                "ARGENTINE",
                "COREE DU SUD",
                "TURQUIE",
                "EGYPTE",
                "NORVEGE",
                "MEDECIN",
                "ENSEIGNANT",
                "INGENIEUR",
                "PLOMBIER",
                "ARTISTE",
                "AVOCAT",
                "INFIRMIER",
                "CHEF CUISINIER",
                "POLICIER",
                "POMPIER",
                "ACTEUR",
                "AGRICULTEUR",
                "ELECTRICIEN",
                "JOURNALISTE",
                "PHOTOGRAPHE",
                "ARCHITECTE",
                "PSYCHOLOGUE",
                "VETERINAIRE",
                "COIFFEUR",
                "CHAUFFEUR DE TAXI",
                "POMME",
                "BANANE",
                "PIZZA",
                "POULET",
                "PATES",
                "BROCOLI",
                "CHOCOLAT",
                "CAROTTE",
                "RIZ",
                "SAUMON",
                "FROMAGE",
                "YAOURT",
                "SALADE",
                "FRAISES",
                "OEUFS",
                "TOMATE",
                "PAIN",
                "POISSON",
                "GATEAU",
                "AVOCAT",
                "ROUGE",
                "BLEU",
                "VERT",
                "JAUNE",
                "ROSE",
                "ORANGE",
                "VIOLET",
                "NOIR",
                "BLANC",
                "GRIS",
                "MARRON",
                "TURQUOISE",
                "INDIGO",
                "BEIGE",
                "ARGENT",
                "DORE",
                "EMERAUDE",
                "CYAN",
                "LILAS",
                "POURPRE",
                "AFRIQUE",
                "AMERIQUE DU NORD",
                "AMERIQUE DU SUD",
                "ASIE",
                "EUROPE",
                "OCEANIE",
                "ANTARCTIQUE",
                "ATLANTIQUE",
                "PACIFIQUE",
                "INDIEN",
                "ARCTIQUE",
                "PARIS",
                "LONDRES",
                "BERLIN",
                "ROME",
                "MADRID",
                "TOKYO",
                "PEKIN",
                "NEW YORK",
                "MOSCOU",
                "BRASILIA",
                "CANBERRA",
                "LE CAIRE",
                "NAIROBI",
                "MEXICO",
                "OTTAWA",
                "BUENOS AIRES",
                "DELHI",
                "BOGOTA",
                "BRUXELLES",
                "AMSTERDAM"
            };
            string word = ChoosingWord(words);
            char[] wordArray = word.ToCharArray();
            char[] hiddenWord = CreateHiddenWord(wordArray);
            bool playing = false;


            while (!Win(wordArray, hiddenWord))
            {
                PlayingRound(wordArray, hiddenWord);
            }
        }

        public static int ChoosingIndexWord(string[] words)
        {
            Random random = new Random();
            int indexOfChoosenWord = random.Next(0, words.Count());
            return indexOfChoosenWord;
        }

        public static string ChoosingWord(string[] words)
        {
            int indexOfChoosenWord = ChoosingIndexWord(words);
            string choosenWord = words[indexOfChoosenWord];
            return choosenWord;
        }

        public static char CheckingInput()
        {
            Console.Write("-> ");
            string input = Console.ReadLine();
            byte[] bytesASCII = Encoding.ASCII.GetBytes(input);
            int valueASCII = Convert.ToInt32(bytesASCII[0]);
            while (input.Length != 1 || valueASCII < 65 || valueASCII > 90)
            {
                Console.Write("Erreur : veuillez entrer une lettre majuscule.\n-> ");
                input = Console.ReadLine();
                bytesASCII = Encoding.ASCII.GetBytes(input);
                valueASCII = Convert.ToInt32(bytesASCII[0]);
            }
            char inputChar = Convert.ToChar(input);
            return inputChar;
        }

        public static char[] CreateHiddenWord(char[] wordArray)
        {
            char[] result = new char[wordArray.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                {
                    result[0] = wordArray[0];
                } else
                {
                    result[i] = '.';
                }
            }
            return result;
        }

        public static void DisplayArray(char[] array)
        {
            Console.WriteLine();
            foreach (char i in array)
            {
                Console.Write(i);
            }
        }

        public static void PlayingRound(char[] wordArray, char[] wordHidden)
        {
            DisplayArray(wordArray);
            DisplayArray(wordHidden);
            Console.WriteLine();
            char input = CheckingInput();

            for (int i = 0; i < wordArray.Count(); i++)
            {
                if (wordArray[i] == input)
                {
                    wordHidden[i] = input;
                }
            }
        }

        public static bool Win(char[] word, char[] wordHidden)
        {
            return word == wordHidden;
        }
    }
}