using System;
using System.Reflection.Metadata;

namespace TP_bot_discord
{
	public class Channel
	{
		public string Name { get; set; }
		public List<Message> History { get; set; }
		public Server Server { get; set; }

		public Channel(string Name, Server Server)
		{
			this.Name = Name;
			this.Server = Server;
			History = new List<Message>();
			Server.Channels.Add(this);
		}

		public void DisplayMessages()
		{
			foreach (Message message in History)
			{
                Console.WriteLine(message.Author.Nickname + " (" + message.DateTimeOfPosting + ") :\n" + message.Content + "\n");
			}
		}
	}
}