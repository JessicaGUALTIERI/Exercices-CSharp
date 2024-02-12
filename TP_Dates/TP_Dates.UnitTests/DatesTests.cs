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
}
