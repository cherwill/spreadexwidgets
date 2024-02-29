using SpreadexWidgets.Widgets;
using System.Text;

namespace SpreadexWidgets.Renderers.V1
{
    public class ConsoleRenderer : IRenderer
    {
        private Stream buffer;

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
            // Check if the buffer is null or disposed
            if (buffer == null || !buffer.CanWrite)
            {
                throw new ObjectDisposedException(nameof(buffer), "Buffer stream is closed or disposed.");
            }

            buffer.Seek(0, SeekOrigin.Begin);
            buffer.CopyTo(stream);
        }
    }
}
