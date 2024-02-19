using TP_POO_Jeu_du_serpent;

namespace TP_POO_Jeu_du_serpents.UnitTests;

[TestClass]
public class UnitTest1
{
    private Player playerTest1;
    private Player playerTest2;
    [TestInitialize]
    public void Init()
    {
        playerTest1 = new Player();
        playerTest2 = new Player();
    }

    [TestMethod]
    [DataRow(51)]
    [DataRow(37)]
    [DataRow(14)]
    [DataRow(46)]
    public void SpaceIsATrap_WithTraps_ReturnsTrue(int space)
    {
        Assert.IsTrue(playerTest1.TheSpaceIsATrap(space));
    }

    [TestMethod]
    [DataRow(50)]
    [DataRow(36)]
    [DataRow(13)]
    [DataRow(45)]
    public void SpaceIsATrap_WithoutTraps_ReturnsFalse(int space)
    {
        Assert.IsFalse(playerTest1.TheSpaceIsATrap(space));
    }

    [TestMethod]
    [DataRow(20)]
    [DataRow(2)]
    [DataRow(31)]
    public void SpaceIsABonus_WithBonus_ReturnsTrue(int space)
    {
        Assert.IsTrue(playerTest1.TheSpaceIsABonus(space));
    }

    [TestMethod]
    [DataRow(21)]
    [DataRow(3)]
    [DataRow(32)]
    public void SpaceIsABonus_WithoutBonus_ReturnsFalse(int space)
    {
        Assert.IsFalse(playerTest1.TheSpaceIsABonus(space));
    }

    [TestMethod]
    [DataRow(50)]
    public void VictoryCondition_With50_ReturnsTrue(int space)
    {
        playerTest1.Space = space;
        Assert.IsTrue(playerTest1.Victory());
    }

    [TestMethod]
    [DataRow(51)]
    public void VictoryCondition_Without50_ReturnsFalse(int space)
    {
        playerTest1.Space = space;
        Assert.IsFalse(playerTest1.Victory());
    }

    [TestMethod]
    public void ThrowingDiceCorrectly()
    {
        int dice = playerTest1.ThrowDice();
        Assert.IsTrue(dice > 0 && dice < 7);
    }

    [TestMethod]
    public void ResettingValuesIsWorking()
    {
        playerTest1.Space = 43;
        playerTest2.Space = 18;
        Game.ResetValues(playerTest1, playerTest2);
        Assert.IsTrue(playerTest1.Space == 1 && playerTest2.Space == 1);
    }
}
