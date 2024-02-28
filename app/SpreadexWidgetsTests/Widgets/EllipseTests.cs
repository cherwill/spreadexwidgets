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

    [TestMethod]

    public void WhenGetDescriptionIsCalled_ThenReturnsValidDescription()
    {
        Ellipse ellipse = new(5, 6, 7, 8);

        string expected = "Ellipse (5,6) diameterH = 7 diameterV = 8";
        string actual = ellipse.ToString();

        Assert.AreEqual(expected, actual);
    }
}
