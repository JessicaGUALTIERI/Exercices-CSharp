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

		public event Action OnNewYear;
        public event Action OnNewMonth;
        public event Action OnNewWeek;
        public event Action OnNewDay;

        public Calendar(int initYear, Month initMonth, Day initDay, int initDayNumber)
		{
			Year = initYear;
			Month = initMonth;
			Day = initDay;
			DayNumber = initDayNumber;
		}

        public void NextDay()
		{
            if (OnNewDay != null)
            {
                OnNewDay();
            }
            if (DayNumber >= DAYS_IN_MONTH)
			{
                NextMonth();
                DayNumber = 1;
            } else
			{
                DayNumber++;
            }
            NextWeek();
        }

        public void NextMonth()
        {
            if (OnNewMonth != null)
            {
                OnNewMonth();
            }
            if (Month == Month.December)
            {
                Month = Month.January;
                NextYear();
            }
            else
            {
                Month++;
            }
        }

        public void NextYear()
        {
            if (OnNewYear != null)
            {
                OnNewYear();
            }
            Year++;
        }

        public void NextWeek()
        {
            if (Day == Day.Sunday)
            {
                if (OnNewWeek != null)
                {
                    OnNewWeek();
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

