using System;
namespace TP_Netflux
{
	public abstract class Content
	{
		public string Name { get; set; }
		public int DurationInMinutes { get; set; }
		public int NumberOfViews { get; set; }

		//public virtual void DisplayNumberOfViews()
		//{
		//	Console.WriteLine("\"" + Name + "\" has been watched " + NumberOfViews + " times.");
		//}
	}
}

