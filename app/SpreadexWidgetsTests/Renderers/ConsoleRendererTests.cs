using SpreadexWidgets.Renderers.V1;
using SpreadexWidgets.Widgets;

namespace SpreadexWidgetsTests.Renderers
{
    [TestClass]
    public class ConsoleRendererTests
    {
        private IRenderer renderer;

        [TestMethod]
        public void GivenSingleShape_ThenRenderDrawing()
        {
            IRenderer renderer = new ConsoleRenderer();
            renderer.DrawSquare(new Square(0, 0, 100));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            stream.Seek(0, SeekOrigin.Begin);
            byte[] readBytes = new byte[stream.Length];
            int bytesRead = stream.Read(readBytes, 0, (int)stream.Length);
            string text = System.Text.Encoding.ASCII.GetString(readBytes, 0, bytesRead);
            Console.WriteLine(text);
        }
    }
}
