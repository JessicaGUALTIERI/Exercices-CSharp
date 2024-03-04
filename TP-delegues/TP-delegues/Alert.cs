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

		public virtual void DisplayMessage(object sender, DetailedAlertArg alertArg)
		{
			Console.WriteLine("\t" + Message);
		}
    }
}