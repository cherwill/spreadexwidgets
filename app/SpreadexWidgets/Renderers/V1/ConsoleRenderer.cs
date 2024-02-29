using SpreadexWidgets.Renderers.V1;
using SpreadexWidgets.Widgets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace SpreadexWidgets.Renderers.V1
{
    public class ConsoleRenderer : IRenderer
    {
        private MemoryStream buffer;

        public ConsoleRenderer()
        {
            this.buffer = new MemoryStream();
        }

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
            //buffer.CopyTo(stream);

            StreamWriter sw = new(stream);
            sw.WriteLine("hello world");
            stream.Position = 0;
        }
    }
}
