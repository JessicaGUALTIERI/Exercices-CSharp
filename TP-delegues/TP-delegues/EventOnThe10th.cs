using System;
namespace TP_delegues
{
	public class EventOnThe10th : Alert
	{
        public EventOnThe10th(string initMessage) : base(initMessage)
		{
		}

        public override void DisplayMessage(object sender, DetailedAlertArg alertArg)
        {
			if (alertArg.DayNumber == 10)
			{
               Console.WriteLine("\t" + Message);
            }
        }
    }
}