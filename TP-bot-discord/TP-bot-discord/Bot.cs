using System;
namespace TP_bot_discord
{
	public class Bot : User
	{
		public string Message { get; set; }
		public Channel Channel { get; set; }

		public Bot(string Nickname, string Message, Channel Channel) : base(Nickname)
		{
			this.Message = Message;
			this.Channel = Channel;
		}

		public void DisplayMessage(object sender, PostArgs postArgs)
		{
			Message message = new Message(this, Message);
			message.Post(Channel);
		}
    }
}