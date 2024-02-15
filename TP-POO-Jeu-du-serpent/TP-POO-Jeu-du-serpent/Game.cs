using System;
namespace TP_POO_Jeu_du_serpent
{
	public class Game
	{
		public static int Round { get; set; }
		public static bool Replay { get; set; }

		public static void StartingGame()
		{
            Console.WriteLine("SNAKE");
			Round = 1;
        }

		public static bool ReplayAnotherGame()
		{
			Console.WriteLine("\nDo you want to play another game ? (y/n)");
			string answer = Console.ReadLine();
			if (answer == "y")
			{
				Replay = true;
			} else
			{
				Replay = false;
			}
			return Replay;
		}

        public static void ResetValues(Player player1, Player player2)
        {
            player1.Space = 1;
            player2.Space = 1;
        }
    }
}

