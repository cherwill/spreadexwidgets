using SpreadexWidgets.Renderers.V1;
using SpreadexWidgets.Widgets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace SpreadexWidgets.Renderers.V1
{
    public class ConsoleRenderer : IRenderer, IDisposable
    {
        private Stream buffer = new MemoryStream();

        public void Dispose()
        {
            buffer?.Dispose();
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
            StringBuilder sb = new();
            sb.AppendFormat("Square ({0},{1}) size={2}", square.XPosition, square.YPosition, square.Width);
            using var streamWriter = new StreamWriter(buffer);
            streamWriter.WriteLine(sb.ToString());
        }

        public void PurgeBuffer()
        {
            buffer?.Dispose();
        }

        public void Render(Stream stream)
        {
            buffer.Seek(0, SeekOrigin.Begin);
            buffer.CopyTo(stream);
        }

        ~ConsoleRenderer()
        {
            // Finalizer to ensure proper disposal in case Dispose is not called explicitly
            Dispose();
        }
    }
}
