namespace FizzBuzzProject.UnitTests;

[TestClass]
public class UnitTest1
{
   

    [TestMethod]
    public void GetOutput_UsingModulos3_ReturnFizz()
    {
        // Act
        string result = FizzBuzz.GetOutput(3);

        // Assert
        Assert.AreEqual(result, "Fizz");
    }

    [TestMethod]
    public void GetOutput_UsingModulos5_ReturnFizz()
    {
        // Act
        string result = FizzBuzz.GetOutput(5);

        // Assert
        Assert.AreEqual(result, "Buzz");
    }

    [TestMethod]
    public void GetOutput_UsingModulos3And5_ReturnBuzz()
    {
        // Act
        string result = FizzBuzz.GetOutput(15);

        // Assert
        Assert.AreEqual(result, "FizzBuzz");
    }

    [TestMethod]
    public void GetOutput_UsingNoModulos_ReturnNumber()
    {
        // Act
        string result = FizzBuzz.GetOutput(4);

        // Assert
        Assert.AreEqual(result, "4");
    }
}
