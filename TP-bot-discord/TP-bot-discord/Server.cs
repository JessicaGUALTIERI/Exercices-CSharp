using System;
namespace TP_bot_discord
{
	public class Server
	{
		public string Name { get; set; }
		public List<Channel> Channels { get; set; }
		public List<User> Users { get; set; }

		public Server(string Name)
		{
			this.Name = Name;
			Channels = new List<Channel>();
			Users = new List<User>();
		}

		public void DisplayServer()
		{
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("[" + Name + "] \n\t[Users] - server");
			Console.ResetColor();
			foreach (User user in Users)
			{
				Console.WriteLine("\t" + user.Nickname);
			}
            foreach (Channel channel in Channels)
			{
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t[" + channel.Name + "] - channel");
                Console.ResetColor();
                channel.DisplayMessages();
			}
        }
	}
}