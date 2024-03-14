using Widgets.Widgets;

namespace WidgetsTests.Widgets;

[TestClass]
public class SquareTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeWidth_ThenThrowsArgumentOutOfRangeException()
    {
        Square square = new(0, 0, -1);
    }
}

