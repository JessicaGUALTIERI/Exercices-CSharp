namespace TP_Dates.UnitTests;

[TestClass]
public class UnitTest1
{
    Dates dateDuJour = new Dates();

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
        dateDuJour.AffectDatesParts(date);
        foreach (string number in dateDuJour.DateArray)
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
        dateDuJour.AffectDatesParts(date);
        int moisATester = dateDuJour.Mois;
        bool result = moisATester > 0 && moisATester < 13;
        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow("12-02-2024")]
    [DataRow("31-12-2011")]
    [DataRow("28-02-2000")]
    public void YearIsCorrect(string date)
    {
        dateDuJour.AffectDatesParts(date);
        int anneeATester = dateDuJour.Annee;
        bool result = anneeATester > 1999 && anneeATester < 2025;
        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow("12-02-2024")]
    [DataRow("31-12-202124")]
    [DataRow("28-02-202124")]
    public void DayIsCorrect(string date)
    {
        dateDuJour.AffectDatesParts(date);
        int jourATester = dateDuJour.Jour;
        int annee = dateDuJour.Annee;
        bool result = false;
        switch (dateDuJour.Mois)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                result = jourATester > 0 && jourATester < 32;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                result = jourATester > 0 && jourATester < 31;
                break;
            case 2:
                if (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
                {
                    result = jourATester > 0 && jourATester < 30;
                    break;
                } else
                {
                    result = jourATester > 0 && jourATester < 29;
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
