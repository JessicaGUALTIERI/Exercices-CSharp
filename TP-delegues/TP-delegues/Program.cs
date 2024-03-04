namespace TP_delegues;

class Program
{
    static void Main(string[] args)
    {
        Calendar calendar = new Calendar(2024, Month.January, Day.Sunday, 1);
        Alert bread = new Alert("Buy bread");
        Alert newspaper = new Alert("Take in the newspaper");
        Alert trash = new Alert("Take out the trash can");
        Alert newCalendar = new Alert("Change to the new calendar");
        EventOnThe10th bills = new EventOnThe10th("Pay the bills");

        calendar.OnNewDay += bread.DisplayMessage;
        calendar.OnNewWeek += newspaper.DisplayMessage;
        calendar.OnNewMonth += trash.DisplayMessage;
        calendar.OnNewYear += newCalendar.DisplayMessage;
        calendar.OnNewDay += bills.DisplayMessage;

        while (calendar.Year != 2025 || calendar.DayNumber != 2)
        {
            calendar.DisplayDate();
            calendar.NextDay();
        }
    }
}