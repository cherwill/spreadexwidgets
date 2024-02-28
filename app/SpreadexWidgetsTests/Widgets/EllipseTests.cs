using SpreadexWidgets.Widgets;

namespace SpreadexWidgetsTests.Widgets;

[TestClass]
public class EllipseTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeHDiameter_ThenThrowsInvalidWidthException()
    {
        Ellipse ellipse = new(0, 0, -1, 0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeYDiameter_ThenThrowsInvalidHeightException()
    {
        Ellipse ellipse = new(0, 0, 0, -1);
    }
}
