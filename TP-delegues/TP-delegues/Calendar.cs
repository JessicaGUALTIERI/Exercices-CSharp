using System;
namespace TP_delegues
{
	public class Calendar
	{
		public int Year { get; set; }
		public Month Month { get; set; }
		public Day Day { get; set; }
		public int DayNumber { get; set; }

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
            DisplayDate();
            if (DayNumber < 31)
			{
				DayNumber++;
            } else
			{
                DayNumber = 1;
                if (OnNewMonth != null)
                {
                    OnNewMonth();
                }
                NextMonth();
            }
            if (OnNewDay != null)
            {
                OnNewDay();
            }
            NextWeek();
        }

        public void NextMonth()
        {
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
            Year++;
            if (OnNewYear != null)
            {
                OnNewYear();
            }
        }

        public void NextWeek()
        {
            if (Day == Day.Sunday)
            {
                Day = Day.Monday;
                if (OnNewWeek != null)
                {
                    OnNewWeek();
                }
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

