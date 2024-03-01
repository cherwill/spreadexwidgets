using SpreadexWidgets.Renderers.V1;
using SpreadexWidgets.Widgets;
using SpreadexWidgets.Enums;
using SpreadexWidgets.Tests.Helpers;

namespace SpreadexWidgets.Tests.Renderers
{
    [TestClass]
    public class TextRendererTests
    {
        private IRenderer renderer;

        [TestInitialize]
        public void Setup()
        {
            renderer = new TextRenderer();
        }

        [TestCleanup]
        public void Cleanup()
        {
            renderer.Dispose();
        }

        [TestMethod]
        public void GivenRectangle_ThenRenderDrawing()
        {
            renderer.DrawRectangle(new Rectangle(1, 2, 3, 4));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            string expected = TextRendererTestHelper.BuildExpected("Rectangle (1,2) width=3 height=4");
            string actual = TextRendererTestHelper.TextFromStream(stream);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenSquare_ThenRenderDrawing()
        {
            renderer.DrawSquare(new Square(1, 2, 3));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            string expected = TextRendererTestHelper.BuildExpected("Square (1,2) size=3");
            string actual = TextRendererTestHelper.TextFromStream(stream);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenEllipse_ThenRenderDrawing()
        {
            renderer.DrawEllipse(new Ellipse(1, 2, 3, 4));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            string expected = TextRendererTestHelper.BuildExpected("Ellipse (1,2) diameterH = 3 diameterV = 4");
            string actual = TextRendererTestHelper.TextFromStream(stream);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenCircle_ThenRenderDrawing()
        {
            renderer.DrawCircle(new Circle(1, 2, 3));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            string expected = TextRendererTestHelper.BuildExpected("Circle (1,2) size = 3");
            string actual = TextRendererTestHelper.TextFromStream(stream);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenTextbox_ThenRenderDrawing()
        {
            renderer.DrawTextbox(new Textbox(1, 2, 3, 4, "sample text"));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            string expected = TextRendererTestHelper.BuildExpected("Textbox (1,2) width=3 height=4 text=\"sample text\"");
            string actual = TextRendererTestHelper.TextFromStream(stream);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMultipleShapes_ThenRenderDrawing()
        {
            renderer.DrawRectangle(new Rectangle(1, 2, 3, 4));
            renderer.DrawSquare(new Square(5, 6, 7));
            renderer.DrawEllipse(new Ellipse(8, 9, 10, 11));
            renderer.DrawCircle(new Circle(12, 13, 14));
            renderer.DrawTextbox(new Textbox(15, 16, 17, 18, "Hello World!"));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            string expected = TextRendererTestHelper.BuildExpected("Rectangle (1,2) width=3 height=4",
                "Square (5,6) size=7",
                "Ellipse (8,9) diameterH = 10 diameterV = 11",
                "Circle (12,13) size = 14",
                "Textbox (15,16) width=17 height=18 text=\"Hello World!\"");
            string actual = TextRendererTestHelper.TextFromStream(stream);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void GivenTextboxWithUnsupportedOrientation_ThenThrowNotSupportedException()
        {
            renderer.DrawTextbox(new Textbox(15, 16, 17, 18, "hello world!", Orientation.VERTICAL));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);
        }

        
    }
}
