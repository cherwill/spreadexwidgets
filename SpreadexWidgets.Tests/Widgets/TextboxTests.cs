using SpreadexWidgets.Widgets;

namespace SpreadexWidgetsTests.Widgets;

[TestClass]
public class TextboxTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeWidth_ThenThrowsArgumentOutOfRangeException()
    {
        Textbox textbox = new(0, 0, -1, 0, "text");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeHeight_ThenThrowsArgumentOutOfRangeException()
    {
        Textbox textbox = new(0, 0, 0, -1, "text");
    }
}
