using SpreadexWidgets.Renderers.V1;
using SpreadexWidgets.Widgets;

namespace SpreadexWidgets.Renderer.V1
{
    public class ConsoleRenderer : IRenderer
    {
        private MemoryStream buffer;
        private string canvasHeader = $"""
            ----------------------------------------------------------------
            Requested Drawing
            ----------------------------------------------------------------

            """;
        private string canvasFooter = $"""

            ----------------------------------------------------------------
            """;

        public ConsoleRenderer()
        {
            this.buffer = new MemoryStream();
        }

        public string CanvasHeader { get { return canvasHeader; } }

        public string CanvasFooter { get { return canvasFooter; } }

        public void DrawEllipse(Ellipse ellipse)
        {
            using var streamWriter = new StreamWriter(buffer);
            streamWriter.Write(ellipse);
        }

        public void DrawRectangle(Rectangle rectangle)
        {
            using var streamWriter = new StreamWriter(buffer);
            streamWriter.Write(rectangle);
        }

        public void DrawSquare(Square square)
        {
            using var streamWriter = new StreamWriter(buffer);
            streamWriter.Write(square);
        }

        public void PurgeBuffer()
        {
            buffer.Dispose();
        }

        public void Render(Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
