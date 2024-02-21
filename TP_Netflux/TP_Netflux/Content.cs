using System;
namespace TP_Netflux
{
	public abstract class Content
	{
		public string Name { get; set; }
		public int DurationInMinutes { get; set; }
		public int NumberOfViews { get; set; }
	}
}

