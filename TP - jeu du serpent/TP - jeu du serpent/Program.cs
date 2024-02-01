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
                pathPlayerOne = 0;
                pathPlayerTwo = 0;
                round = 0;
                while (pathPlayerOne != 50 && pathPlayerTwo != 50)
                {
                    round++;
                    pathPlayerOne = PlayingRound(namePlayerOne, pathPlayerOne, round);

                    if (pathPlayerOne != 50)
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
            playerPath += dice;
            Console.Write("\nMANCHE " + round + " :\n\t" + playerName + " lance le dé : +" + dice + " !");
            if (playerPath > 50)
            {
                playerPath = 25;
                Console.WriteLine(" Oh non, c'est trop pour atteindre la bonne case, retour case 25 !");
            }
            else
            {
                Console.WriteLine(" et avance à la case " + playerPath);
            }
            if (playerPath == 50)
            {
                Console.WriteLine("\nFélicitations " + playerName + " ! Tu as atteint l'arrivée en " + round + " manches !");
            }
            return playerPath;
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
    }
}