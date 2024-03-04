using System;
namespace TP_delegues
{
	public class DetailedAlertArg : EventArgs
	{
        public int Year { get; set; }
        public Month Month { get; set; }
        public Day Day { get; set; }
        public int DayNumber { get; set; }

        public DetailedAlertArg(int initYear, Month initMonth, Day initDay, int initDayNumber)
		{
            Year = initYear;
            Month = initMonth;
            Day = initDay;
            DayNumber = initDayNumber;
        }
	}
}