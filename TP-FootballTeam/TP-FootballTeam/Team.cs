using System;
namespace TP_FootballTeam
{
	public class Team
	{
		public string Name { get; set; }
		public List<Player> Players { get; set; }
        public int numbersOfPlayersPlaying { get; set; }
        public int numbersOfPlayersSubstitute { get; set; }
        public int numbersOfPlayersInjured { get; set; }
        public int numbersOfPlayersPenalized { get; set; }

        public Team(string initName)
		{
			Name = initName;
		}

		public void Initialize()
		{
			Players = new List<Player>();
		}

		public void AddPlayer(Player player)
        { 
			Players.Add(player);
		}

		public void ChangeOfPlayer(Player replacedPlayer, Player replacingPlayer)
		{
			replacedPlayer.ChangeStatus(PlayerStatus.Substitute);
			replacingPlayer.ChangeStatus(PlayerStatus.Playing);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n[" + replacedPlayer.Team.Name + "] " + replacedPlayer.FirstName + " " + replacedPlayer.LastName + " is replaced by " + replacingPlayer.FirstName + " " + replacingPlayer.LastName + ".");
            Console.ResetColor();
        }


        public void DisplayPlayers()
		{
            CountOfPlayers();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n" + Name + "'s players are : ");
            Console.ResetColor();
            Console.WriteLine(); // Had to reset color before a new line. If not, the blank space was still white.
            DisplayPlayersPlaying();
            DisplayPlayersSubstitute();
            DisplayPlayersInjured();
            DisplayPlayersPenalized();
            DisplayPlayersWithCards();
		}

		public void DisplayPlayersPlaying()
		{
            if (numbersOfPlayersPlaying > 0)
            {
                Console.WriteLine("\t" + numbersOfPlayersPlaying + " players playing for :");
                foreach (Player player in Players)
                {
                    if (player.Status == PlayerStatus.Playing)
                    {
                        Console.WriteLine("\t\t- " + player.FirstName + " " + player.LastName);
                    }
                }
            }
		}

        public void DisplayPlayersSubstitute()
        {
            if (numbersOfPlayersSubstitute > 0)
            {
                Console.WriteLine("\t" + numbersOfPlayersSubstitute + " players substitute :");
                foreach (Player player in Players)
                {
                    if (player.Status == PlayerStatus.Substitute)
                    {
                        Console.WriteLine("\t\t- " + player.FirstName + " " + player.LastName);
                    }
                }
            }
        }

        public void DisplayPlayersInjured()
        {
            if (numbersOfPlayersInjured > 0)
            {
                Console.WriteLine("\t" + numbersOfPlayersInjured + " players injured :");
                foreach (Player player in Players)
                {
                    if (player.Status == PlayerStatus.Injured)
                    {
                        Console.WriteLine("\t\t- " + player.FirstName + " " + player.LastName);
                    }
                }
            }
        }

        public void DisplayPlayersPenalized()
        {
            if (numbersOfPlayersPenalized > 0)
            {
                Console.WriteLine("\t" + numbersOfPlayersPenalized + " players penalized from playing :");
                foreach (Player player in Players)
                {
                    if (player.Status == PlayerStatus.Penalized)
                    {
                        Console.WriteLine("\t\t- " + player.FirstName + " " + player.LastName);
                    }
                }
            }
        }

        public void CountOfPlayers()
		{
			numbersOfPlayersPlaying = 0;
			numbersOfPlayersSubstitute = 0;
			numbersOfPlayersInjured = 0;
			numbersOfPlayersPenalized = 0;
			foreach (Player player in Players)
			{
				switch(player.Status)
				{
					case PlayerStatus.Playing :
						numbersOfPlayersPlaying++;
						break;
                    case PlayerStatus.Substitute:
                        numbersOfPlayersSubstitute++;
                        break;
                    case PlayerStatus.Injured:
                        numbersOfPlayersInjured++;
                        break;
                    case PlayerStatus.Penalized:
                        numbersOfPlayersPenalized++;
                        break;
                }

            }
		}

        public void DisplayPlayersWithCards()
        {
            int numberOfPlayersWithCards = 0;
            foreach (Player player in Players)
            {
                if (player.Cards > 0)
                {
                    numberOfPlayersWithCards++;
                }
            }
            if (numberOfPlayersWithCards > 0)
            {
                Console.WriteLine("\t" + numberOfPlayersWithCards + " players with cards :");
                foreach (Player player in Players)
                {
                    if (player.Cards > 0)
                    {
                        Console.Write("\t\t - " + player.FirstName + " " + player.LastName + " (");
                        if (player.Cards == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("carton jaune)");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("carton rouge)");
                            Console.ResetColor();
                        }
                    }
                }
            }
        }
	}
}