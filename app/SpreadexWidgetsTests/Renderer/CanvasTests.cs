using SpreadexWidgets.Widgets;
using SpreadexWidgets.Renderer;
using System.Text;

namespace SpreadexWidgetsTests.Renderer
{
    [TestClass]
    public class CanvasTests
    {
        private string canvasHeader = $"""
            ----------------------------------------------------------------
            Requested Drawing
            ----------------------------------------------------------------

            """;
        private string canvasFooter = $$"""

            ----------------------------------------------------------------
            """;


        [TestMethod]
        public void GivenSingleShape_ThenRenderDrawing()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(0, 0, 5, 5)
            };

            Canvas canvas = new(shapes);

            string expected = GetExpectedDrawing(shapes);
            string actual = canvas.Render();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMultipleShapes_ThenRenderDrawing()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(1, 2, 3, 4),
                new Square(5, 6, 7),
                new Ellipse(9, 10, 11, 12)
            };

            Canvas canvas = new(shapes);

            string expected = GetExpectedDrawing(shapes);
            string actual = canvas.Render();

            Assert.AreEqual(expected, actual);
        }

        private string GetExpectedDrawing(List<Shape> shapes)
        {
            StringBuilder expectedBuilder = new StringBuilder();
            expectedBuilder.Append(canvasHeader);
            expectedBuilder.Append(string.Join(Environment.NewLine, shapes));
            expectedBuilder.Append(canvasFooter);

            return expectedBuilder.ToString();
        }
    }
}
