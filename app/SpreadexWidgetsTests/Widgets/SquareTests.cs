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

    [TestMethod]
    public void WhenGetDescriptionIsCalled_ThenReturnsValidDescription()
    {
        Square square = new(5, 6, 7);

        string expected = "Square (5,6) size=7";
        string actual = square.ToString();

        Assert.AreEqual(expected, actual);
    }
}

