namespace Evaluation.UnitTests;
using EvaluationSampleCode;
using static System.Runtime.InteropServices.JavaScript.JSType;

[TestClass]
public class PhoneNumberTests
{
    private PhoneNumber _phoneNumber = PhoneNumber.Parse("0123456789");

    [TestMethod]
    public void Parse_WithValidPhonenumber_ReturnCorrectPhoneNumber()
    {
        //Arrange
        string myNumber = "0123456789";

        //Act && Assert
        Assert.AreEqual("012", PhoneNumber.Parse("0123456789").Area);
        Assert.AreEqual("345", PhoneNumber.Parse("0123456789").Major);
        Assert.AreEqual("6789", PhoneNumber.Parse("0123456789").Minor);

    }

    [TestMethod]
    [DataRow(" ")]
    [DataRow("23456789345678")]
    [DataRow("4567890  7890  ")]
    [DataRow("   4567890  7890  ")]
    public void Parse_WithInvalidPhonenumber_ThrowArgumentException(string myNumber)
    {
        //Act && Assert
        Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(myNumber));

    }

    [TestMethod]
    public void ToString_WithValidPhonenumber_ReturnCorrectPhoneNumberInString()
    {
        //Act && Assert
        Assert.AreEqual("(012)345-6789", _phoneNumber.ToString());
    }
}

