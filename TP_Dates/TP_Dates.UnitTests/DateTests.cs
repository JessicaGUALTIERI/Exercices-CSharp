namespace TP_Dates.UnitTests;

[TestClass]
public class UnitTest1
{
    Date dateTested = new Date();

    [TestMethod]
    [DataRow("12-02-2024")]
    [DataRow("--")]
    public void HyphensAre2(string date)
    {
        int numberOfHyphens = 0;
        foreach (char character in date)
        {
            if (character == '-')
            {
                numberOfHyphens++;
            }
        }
        Assert.IsTrue(numberOfHyphens == 2);
    }

    [TestMethod]
    [DataRow("12-02-2024")]
    [DataRow("122918-0212212-20214")]
    public void NumericsOnlyBetweenHyphens(string date)
    {
        dateTested.SplitGivenDate(date);
        foreach (string number in dateTested.DateArray)
        {
            int i = 0;
            bool result = int.TryParse(number, out i);
            Assert.IsTrue(result);
        }
    }

    [TestMethod]
    [DataRow("12-02-2024")]
    [DataRow("1122-12-202124")]
    public void MonthIsCorrect(string date)
    {
        dateTested.SplitGivenDate(date);
        int monthTested = dateTested.Month;
        bool result = monthTested > 0 && monthTested < 13;
        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow("12-02-2024")]
    [DataRow("31-12-2011")]
    [DataRow("28-02-2000")]
    public void YearIsCorrect(string date)
    {
        dateTested.SplitGivenDate(date);
        int yearTested = dateTested.Year;
        bool result = yearTested > 1999 && yearTested < 2025;
        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow("12-02-2024")]
    [DataRow("31-12-202124")]
    [DataRow("28-02-202124")]
    public void DayIsCorrect(string date)
    {
        dateTested.SplitGivenDate(date);
        int dayTested = dateTested.Day;
        int year = dateTested.Year;
        bool result = false;
        switch (dateTested.Month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                result = dayTested > 0 && dayTested < 32;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                result = dayTested > 0 && dayTested < 31;
                break;
            case 2:
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    result = dayTested > 0 && dayTested < 30;
                    break;
                } else
                {
                    result = dayTested > 0 && dayTested < 29;
                    break;
                }
                
        }
        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow("29-02-2024")]
    [DataRow("31-12-2001")]
    [DataRow("01-02-2011")]
    public void DateIsValid(string date)
    {
        HyphensAre2(date);
        NumericsOnlyBetweenHyphens(date);
        MonthIsCorrect(date);
        YearIsCorrect(date);
        DayIsCorrect(date);
    }
}
