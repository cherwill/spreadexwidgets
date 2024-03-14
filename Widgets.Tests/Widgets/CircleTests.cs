using Widgets.Widgets;

namespace WidgetsTests.Widgets;

[TestClass]
public class CircleTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GivenNegativeDiameter_ThenThrowsArgumentOutOfRangeException()
    {
        Circle circle = new(0, 0, -1);
    }
}
