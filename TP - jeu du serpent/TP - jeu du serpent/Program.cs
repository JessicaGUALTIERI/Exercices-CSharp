using System;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|| Jeu du serpent ||" +
                "\nEntrez le nom des deux joueurs :" +
                "\n\tJoueur 1 :");
            string namePlayerOne = Console.ReadLine();
            Console.WriteLine("\n\tJoueur 2 :");
            string namePlayerTwo = Console.ReadLine();

            Random random = new Random();
            int dice;
            int pathPlayerOne = 1;
            int pathPlayerTwo = 1;
            int round = 0;
            bool playing = true;

            do
            {
                pathPlayerOne = 1;
                pathPlayerTwo = 1;
                round = 0;
                while (!Win(pathPlayerOne, pathPlayerTwo))
                {
                    round++;
                    Console.WriteLine("\nMANCHE " + round);

                    pathPlayerOne = PlayingRound(namePlayerOne, pathPlayerOne, round);

                    if (!Win(pathPlayerOne, pathPlayerTwo))
                    {
                        pathPlayerTwo = PlayingRound(namePlayerTwo, pathPlayerTwo, round);
                    }
                }
                playing = Replay();
            } while (playing);
        }

        public static int ThrowingDice()
        {
            Random random = new Random();
            int dice;
            dice = random.Next(1, 7);
            return dice;
        }

        public static int PlayingRound(string playerName, int playerPath, int round)
        {
            int dice = ThrowingDice();
            Console.Write("\t" + playerName + "[" + playerPath + "]");
            playerPath += dice;
            Console.Write(" lance le dé : +" + dice + " !");
            switch(playerPath)
            {
                case > 50:
                    playerPath = 25;
                    Console.WriteLine(" Oh non, c'est trop pour atteindre la bonne case, retour case 25 !");
                    break;
                case 37:
                    playerPath = 12;
                    DisplayTrap(playerPath);
                    break;
                case 14:
                    playerPath = 7;
                    DisplayTrap(playerPath);
                    break;
                case 46:
                    playerPath = 33;
                    DisplayTrap(playerPath);
                    break;
                case 20:
                    playerPath = 35;
                    DisplayBonus(playerPath);
                    break;
                case 2:
                    playerPath = 17;
                    DisplayBonus(playerPath);
                    break;
                case 31:
                    playerPath = 43;
                    DisplayBonus(playerPath);
                    break;
                default:
                    Console.WriteLine(" Elle avance à la case " + playerPath);
                    break;
            }
            if (playerPath == 50)
            {
                Console.WriteLine("\nFélicitations " + playerName + " ! Tu as atteint l'arrivée en " + round + " manches !");
            }
            return playerPath;
        }

        public static void DisplayTrap(int position)
        {
            Console.WriteLine(" Oh non, case piégée, retour case " + position + " !");
        }

        public static void DisplayBonus(int position)
        {
            Console.WriteLine(" Quelle chance, case bonus, avancée fulgurante à la case " + position + " !");
        }

        public static bool Replay()
        {
            Console.WriteLine("\nVoulez-vous rejouer (y/n) ?");
            string inputPlaying = Console.ReadLine();
            while (inputPlaying != "y" && inputPlaying != "n")
            {
                Console.WriteLine("\nErreur : veuillez réessayer (y/n).");
                inputPlaying = Console.ReadLine();
            }
            if (inputPlaying == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Win(int playerPathOne, int playerPathTwo)
        {
            return playerPathOne == 50 || playerPathTwo == 50;
        }
    }
}