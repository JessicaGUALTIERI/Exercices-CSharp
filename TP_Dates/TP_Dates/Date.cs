using System;
namespace TP_Dates
{
	public class Date
	{
		public int Day { get; set; }
		public int Month { get; set; }
		public int Year { get; set; }
		public string[] DateArray { get; set; }

		public void SplitGivenDate(string date)
		{
			DateArray = date.Split("-");
			Day = Convert.ToInt32(DateArray[0]);
			Month = Convert.ToInt32(DateArray[1]);
			Year = Convert.ToInt32(DateArray[2]);
		}
	}
}

