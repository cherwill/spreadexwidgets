using SpreadexWidgets.Widgets;

namespace SpreadexWidgetsTests.Widgets;

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

    [TestMethod]
    public void GivenHeightChange_ThenReflectNewHeight()
    {
        Rectangle rectangle = new(1, 2, 3, 4);

        var expected = 6;

        rectangle.UpdateHeight(6);
        Assert.AreEqual(expected, rectangle.Height);

        expected = 7;

        rectangle.UpdateHeight(7);
        Assert.AreEqual(expected, rectangle.Height);

        expected = 6;

        rectangle.revertHeightChange();
        Assert.AreEqual(expected, rectangle.Height);

        expected = 4;

        rectangle.revertHeightChange();
        Assert.AreEqual(expected, rectangle.Height);


    }

        [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void GivenZero_ThenThrowsDivideByZeroException()
    {
        calculate(5,0);
    }

    public int calculate(int a, int b) {
        return a / b;
    }


}
