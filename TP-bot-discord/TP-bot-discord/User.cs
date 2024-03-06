using System;
namespace TP_bot_discord
{
	public class User
	{
		public string Nickname { get; set; }

		public User(string Nickname)
		{
			this.Nickname = Nickname;
		}

		public void JoinServer(Server server)
		{
			server.Users.Add(this);
		}
	}
}