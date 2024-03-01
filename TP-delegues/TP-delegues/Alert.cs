using System;
namespace TP_delegues
{
	public class Alert
	{
		public string Message { get; set; }

		public Alert(string initMessage)
		{
			Message = initMessage;
		}

		public void DisplayMessage()
		{
			Console.WriteLine("\t" + Message);
		}
	}
}

