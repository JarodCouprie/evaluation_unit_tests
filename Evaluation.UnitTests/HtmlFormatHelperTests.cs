namespace Evaluation.UnitTests;
using EvaluationSampleCode;

[TestClass]
public class HtmlFormatHelperTests
{
    private HtmlFormatHelper _htmlFormatHelper = new HtmlFormatHelper();

    [TestMethod]
    [DataRow("AAAA")]
    [DataRow("BBBB")]
    public void GetStrongFormat_WithContentString_ReturnContentStringWithStrongContent(string content)
    {
        //Arrange
        string value = $"<strong>{content}</strong>";

        //Act && Assert
        Assert.AreEqual(value, _htmlFormatHelper.GetStrongFormat(content));
    }

    [TestMethod]
    [DataRow("AAAA")]
    [DataRow("BBBB")]
    public void GetItalicFormat_WithContentString_ReturnContentStringWithItalicContent(string content)
    {
        //Arrange
        string value = $"<i>{content}</i>";

        //Act && Assert
        Assert.AreEqual(value, _htmlFormatHelper.GetItalicFormat(content));

    }

    [TestMethod]
    public void GetFormattedListElements_ListOfString_ReturnOneHTMLListOfString()
    {
        List<string> content = new List<string> { "A", "B", "C", "D" };

        Assert.AreEqual("<ul><li>A</li><li>B</li><li>C</li><li>D</li></ul>", _htmlFormatHelper.GetFormattedListElements(content));

    }
}

