using System;
namespace TP_delegues
{
	public class Calendar
	{
		public int Year { get; set; }
		public Month Month { get; set; }
		public Day Day { get; set; }
		public int DayNumber { get; set; }
        const int DAYS_IN_MONTH = 31;

		public event EventHandler<DetailedAlertArg> OnNewYear;
        public event EventHandler<DetailedAlertArg> OnNewMonth;
        public event EventHandler<DetailedAlertArg> OnNewWeek;
        public event EventHandler<DetailedAlertArg> OnNewDay;

        public Calendar(int initYear, Month initMonth, Day initDay, int initDayNumber)
		{
			Year = initYear;
			Month = initMonth;
			Day = initDay;
			DayNumber = initDayNumber;
		}

        public void NextDay()
		{
            DetailedAlertArg alert = new DetailedAlertArg(Year, Month, Day, DayNumber);
            if (OnNewDay != null)
            {
                OnNewDay(this, alert);
            }
            if (DayNumber >= DAYS_IN_MONTH)
			{
                if (OnNewMonth != null)
                {
                    OnNewMonth(this, alert);
                }
                if (Month == Month.December)
                {
                    Month = Month.January;
                    if (OnNewYear != null)
                    {
                        OnNewYear(this, alert);
                    }
                    Year++;
                }
                else
                {
                    Month++;
                }
                DayNumber = 1;
            } else
			{
                DayNumber++;
            }
            if (Day == Day.Sunday)
            {
                if (OnNewWeek != null)
                {
                    OnNewWeek(this, alert);
                }
                Day = Day.Monday;
            }
            else
            {
                Day++;
            }
        }

        public void DisplayDate()
        {
            Console.WriteLine(Day + " " + DayNumber + " " + Month + " " + Year);
        }
    }
}