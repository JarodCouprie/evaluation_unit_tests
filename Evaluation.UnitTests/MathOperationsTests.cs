using System;
namespace Evaluation.UnitTests;
using EvaluationSampleCode;

[TestClass]
public class MathOperationsTests
{
    private MathOperations _mathOperations = new MathOperations();

    [TestMethod]
    [DataRow(123,12)]
    [DataRow(1199, 134)]
    [DataRow(1123, 152)]
    public void Substract_WithTwoNumbers_ReturnCalculationOfNumberOneMinusNumberTwo(int numberOne, int numberTwo)
    {
        //Arrange
        int operation = numberOne - numberTwo;

        //Act && Assert
        Assert.AreEqual(operation, _mathOperations.Subtract(numberOne, numberTwo));

    }


    [TestMethod]
    [DataRow(12300, 12)]
    [DataRow(1234, 12344)]
    [DataRow(1123, 12345)]
    public void Substract_WithNumbersOutOfConditions_ReturnArgumentException(int numberOne, int numberTwo)
    {
        //Act && Assert
        Assert.ThrowsException<ArgumentException>(()=> _mathOperations.Subtract(numberOne, numberTwo));
    }

    [TestMethod]
    [DataRow(12)]
    [DataRow(34)]
    [DataRow(6)]
    public void GetColorFromOddsNumber_WithOddNumber_ReturnStringRed(int number)
    {
        //Act && Assert
        Assert.AreEqual("Red", _mathOperations.GetColorFromOddsNumber(number));
    }

    [TestMethod]
    [DataRow(13)]
    [DataRow(35)]
    [DataRow(7)]
    public void GetColorFromOddsNumber_WithEvenNumber_ReturnStringBlue(int number)
    {
        //Act && Assert
        Assert.AreEqual("Blue", _mathOperations.GetColorFromOddsNumber(number));
    }

    [TestMethod]
    [DataRow(-12)]
    [DataRow(-34)]
    [DataRow(-1)]
    public void GetColorFromOddsNumber_WithNegativeNumber_ThrowArgumentException(int number)
    {
        //Act && Assert
        Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetColorFromOddsNumber(number));
    }


}

