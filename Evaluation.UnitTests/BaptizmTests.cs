namespace Evaluation.UnitTests;
using EvaluationSampleCode;

[TestClass]
public class BaptizmTests
{
    private Baptizm _baptiz;

    [TestMethod]
    public void CanBeBaptizedBy_WithClergyMemberIsPriestTrue_ReturnTrue()
    {
        //Arrange
        ClergyMember clergyMember = new ClergyMember();
        clergyMember.IsPriest = true;
        _baptiz = new Baptizm(clergyMember);

        //Act && Assert
        Assert.AreEqual(true, _baptiz.CanBeBaptizedBy(clergyMember));
    }

    [TestMethod]
    public void CanBeBaptizedBy_WithClergyMemberIsPopeTrue_ReturnTrue()
    {
        //Arrange
        ClergyMember clergyMember = new ClergyMember();
        clergyMember.IsPope = true;
        _baptiz = new Baptizm(clergyMember);

        //Act && Assert
        Assert.AreEqual(true, _baptiz.CanBeBaptizedBy(clergyMember));
    }

    [TestMethod]
    public void CanBeBaptizedBy_WithClergyMemberIsPopeTrueAndIsPriestTrue_ReturnTrue()
    {
        //Arrange
        ClergyMember clergyMember = new ClergyMember();
        clergyMember.IsPriest = true;
        clergyMember.IsPope = true;
        _baptiz = new Baptizm(clergyMember);

        //Act && Assert
        Assert.AreEqual(true, _baptiz.CanBeBaptizedBy(clergyMember));
    }

    [TestMethod]
    public void CanBeBaptizedBy_WithClergyMemberIsPopeFalseAndIsPriestFalse_ReturnFalse()
    {
        //Arrange
        ClergyMember clergyMember = new ClergyMember();
        _baptiz = new Baptizm(clergyMember);

        //Act && Assert
        Assert.AreEqual(false, _baptiz.CanBeBaptizedBy(clergyMember));
    }

    [TestMethod]
    public void CanBeTeachedBy_WithClergyMember_ReturnTrue()
    {
        //Arrange
        ClergyMember clergyMember = new ClergyMember();
        _baptiz = new Baptizm(clergyMember);

        //Act && Assert
        Assert.AreEqual(true, _baptiz.CanBeTeachedBy(clergyMember));
    }

    [TestMethod]
    public void CanBeTeachedBy_WithoutClergyMember_ReturnFalse()
    {
        //Arrange
        _baptiz = new Baptizm(null);

        //Act && Assert
        Assert.AreEqual(false, _baptiz.CanBeTeachedBy(new ClergyMember()));
    }
}
