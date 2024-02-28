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
}
