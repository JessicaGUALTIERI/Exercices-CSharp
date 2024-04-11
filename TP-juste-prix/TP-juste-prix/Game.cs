using System;
using System.Text.Json;

namespace TP_juste_prix
{
	public class Game
	{
		public int GameId { get; set; }
		public int Score { get; set; }

		public int GetMaxId()
		{
			Game maxIdGame = new Game();
			if (Database.Games.Count() > 0)
				maxIdGame = Database.Games.Last();
				if (maxIdGame.GameId >= 0 && maxIdGame != null)
					return maxIdGame.GameId;
			else
				return 1;
		}

		public Game(int score)
		{
			GameId = GetMaxId() + 1;
			Score = score;
			Database.Games.Add(this);
		}

        public Game()
        {
        }

		
    }
}

