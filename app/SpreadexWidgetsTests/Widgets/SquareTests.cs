using SpreadexWidgets.Widgets;

namespace SpreadexWidgetsTests.Widgets;

[TestClass]
public class SquareTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeWidth_ThenThrowsInvalidWidthException()
    {
        Square square = new(0, 0, -1);
    }
}

