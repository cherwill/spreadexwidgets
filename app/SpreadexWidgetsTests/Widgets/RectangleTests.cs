using SpreadexWidgets.Widgets;

namespace SpreadexWidgetsTests.Widgets;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeWidth_ThenThrowsInvalidWidthException()
    {
        Rectangle rectangle = new(0, 0, -1, 0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeHeight_ThenThrowsInvalidHeightException()
    {
        Rectangle rectangle = new(0, 0, 0, -1);
    }

    [TestMethod]

    public void WhenGetDescriptionIsCalled_ThenReturnsValidDescription()
    {
        Rectangle rectangle = new(5, 6, 7, 8);

        string expected = "Rectangle (5,6) width=7 height=8";
        string actual = rectangle.ToString();

        Assert.AreEqual(expected, actual);
    }
}
