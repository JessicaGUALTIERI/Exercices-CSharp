namespace TP_calculatrice.UnitTests;

[TestClass]
public class UnitTest1
{
    private Calculatrice _calculatrice;

    [TestInitialize]
    public void Init()
    {
        _calculatrice = new Calculatrice();
    }

    [DataRow(0, 4)]
    [DataRow(4, 0)]
    [DataRow(0, 0)]
    [TestMethod]
    public void IsNotZero_WithAZero_ReturnFalse(int numberOne, int numberTwo)
    {
        // Arrange
        _calculatrice.Divide(numberOne, numberTwo);

        // Act
        bool result = _calculatrice.IsNotZero();

        // Assert
        Assert.IsFalse(result);
    }

    [DataRow(10,4,2.5f)]
    [DataRow(100, 10, 10)]
    [DataRow(110, 11, 10)]
    [TestMethod]
    public void DivideTwoNumbers_ReturnDivision(int numberOne, int numberTwo, float result)
    {
        // Arrange
        float testResultDivision = _calculatrice.Divide(numberOne, numberTwo);

        // Act

        // Assert
        Assert.AreEqual(result, testResultDivision);
    }

    [DataRow(10, 10, 20)]
    [DataRow(1, 10, 11)]
    [DataRow(100, 0, 100)]
    [TestMethod]
    public void AddTwoNumbers_ReturnAddition(int numberOne, int numberTwo, int result)
    {
        // Arrange
        int testResultAddition = _calculatrice.Add(numberOne, numberTwo);

        // Act

        // Assert
        Assert.AreEqual(result, testResultAddition);
    }

    [DataRow(10, 4, 6)]
    [DataRow(10, 100, -90)]
    [DataRow(110, 0, 110)]
    [TestMethod]
    public void SubstractTwoNumbers_ReturnSubstraction(int numberOne, int numberTwo, int result)
    {
        // Arrange
        int testResultSubstraction = _calculatrice.Substract(numberOne, numberTwo);

        // Act

        // Assert
        Assert.AreEqual(result, testResultSubstraction);
    }

    [DataRow(10, 4, 40)]
    [DataRow(100, 10, 1000)]
    [DataRow(0, 11, 0)]
    [TestMethod]
    public void MultiplyTwoNumbers_ReturnMultiplication(int numberOne, int numberTwo, int result)
    {
        // Arrange
        int testResultMultiplication = _calculatrice.Multiply(numberOne, numberTwo);

        // Act

        // Assert
        Assert.AreEqual(result, testResultMultiplication);
    }
}
