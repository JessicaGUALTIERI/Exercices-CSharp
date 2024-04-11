using System;
namespace TP_juste_prix
{
	public static class Database
	{
        public static List<Game> Games { get; set; } = new List<Game>();

        public static void Initialize()
		{
            Games = new List<Game>();
        }

        public static void DisplayDatabase()
        {
            foreach (Game game in Games)
            {
                Console.WriteLine("Game n°" + game.GameId + " : " + game.Score);
            }
        }
    }
}

