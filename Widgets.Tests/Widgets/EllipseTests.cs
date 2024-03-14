using Widgets.Widgets;

namespace WidgetsTests.Widgets;

[TestClass]
public class EllipseTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeDiameterH_ThenThrowsArgumentOutOfRangeException()
    {
        Ellipse ellipse = new(0, 0, -1, 0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeDiameterY_ThenThrowsArgumentOutOfRangeException()
    {
        Ellipse ellipse = new(0, 0, 0, -1);
    }
}
