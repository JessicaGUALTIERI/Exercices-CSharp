namespace workshop_final.UnitTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow("M0tdep@sse")]
    [DataRow("Aj3!K_&UioP")]
    public void PasswordIsValid_UsingValidInput_ReturnTrue(string password)
    {
        // Act
        bool result = UserRepository.IsPasswordCorrect(password);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow("motdepasse")]
    [DataRow(" ")]
    [DataRow("")]
    public void PasswordIsValid_UsingInvalidInput_ReturnFalse(string password)
    {
        // Act
        bool result = UserRepository.IsPasswordCorrect(password);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    [DataRow("jessica@mail.fr")]
    [DataRow("jess_ica@mail-mail.com")]
    public void MailIsValid_UsingValidInput_ReturnTrue(string mail)
    {
        // Act
        bool result = UserRepository.IsMailValid(mail);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow("jessica")]
    [DataRow("jessica@")]
    [DataRow("jessica@live")]
    [DataRow("jessica@live.")]
    [DataRow("jessica@live.f")]
    [DataRow(" ")]
    [DataRow("")]
    public void MailIsValid_UsingInvalidInput_ReturnFalse(string mail)
    {
        // Act
        bool result = UserRepository.IsMailValid(mail);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    [DataRow("12345678910")]
    public void PasswordHasValidLength_UsingValidInput_ReturnTrue(string password)
    {
        // Act
        bool result = UserRepository.IsPasswordsLengthValid(password);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow("1234567891011121314151617181920")]
    [DataRow("")]
    public void PasswordHasValidLength_UsingInvalidInput_ReturnFalse(string password)
    {
        // Act
        bool result = UserRepository.IsPasswordsLengthValid(password);

        // Assert
        Assert.IsFalse(result);
    }
}
