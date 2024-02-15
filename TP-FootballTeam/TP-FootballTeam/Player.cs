using System;
namespace TP_FootballTeam
{
	public class Player
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Cards { get; set; }
		public Team Team { get; set; }
		public PlayerStatus Status { get; set; }
		public List<string> TeamsHistoric { get; set; }

		public Player(Team initTeam, string initFirstName, string initLastName, PlayerStatus initStatus)
		{
			Team = initTeam;
			FirstName = initFirstName;
			LastName = initLastName;
			Cards = 0;
			Team.AddPlayer(this);
			Status = initStatus;
			TeamsHistoric = new List<string> { Team.Name };
		}

		public void YellowCard()
		{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[" + Team.Name + "] " + FirstName + " " + LastName + " has received a yellow card !");
            Console.ForegroundColor = ConsoleColor.White;
            Cards++;
			CheckingCards();
		}

		public void RedCard()
		{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[" + Team.Name + "] " + FirstName + " " + LastName + " has received a red card !");
            Console.ForegroundColor = ConsoleColor.White;
            Cards = 2;
			CheckingCards();
		}

		public void CheckingCards()
		{
			if (Cards == 2)
			{
				ChangeStatus(PlayerStatus.Penalized);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[" + Team.Name + "] " + FirstName + " " + LastName + " is now penalized for the rest of the match !");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void ChangeStatus(PlayerStatus newStatus)
        {
			Status = newStatus;
        }

        public void GetsInjuredAndReplacedBy(Player replacingPlayer)
        {
            ChangeStatus(PlayerStatus.Injured);
            replacingPlayer.ChangeStatus(PlayerStatus.Playing);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n[" + Team.Name + "] " + FirstName + " " + LastName + " is injured and has to be replaced by " + replacingPlayer.FirstName + " " + replacingPlayer.LastName + ".");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DisplayTeamsHistoric()
		{
			Console.WriteLine("\n" + FirstName + " " + LastName + " has played for :");
			foreach (string teamName in TeamsHistoric)
			{
				if (teamName == Team.Name)
				{
                    Console.WriteLine("\t - " + teamName + " (current team)");
                } else
				{
                    Console.WriteLine("\t - " + teamName);
                }
            }
		}

		public void ChangeTeam(Team newTeam)
		{
            Console.Write("\n" + FirstName + " " + LastName + " leaves " + Team.Name + " for ");
			Team.Players.Remove(this);
            Team = newTeam;
			TeamsHistoric.Add(newTeam.Name);
			Console.WriteLine(Team.Name);
        }
    }
}