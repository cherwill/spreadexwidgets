using Widgets.Widgets;

namespace WidgetsTests.Widgets;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeWidth_ThenThrowsArgumentOutOfRangeException()
    {
        Rectangle rectangle = new(0, 0, -1, 0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeHeight_ThenThrowsArgumentOutOfRangeException()
    {
        Rectangle rectangle = new(0, 0, 0, -1);
    }
}
