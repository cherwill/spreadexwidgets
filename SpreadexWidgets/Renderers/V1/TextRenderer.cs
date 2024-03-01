using SpreadexWidgets.Providers;
using SpreadexWidgets.Widgets;
using SpreadexWidgets.Enums;
using System.Text;

namespace SpreadexWidgets.Renderers.V1
{
    public class TextRenderer : IRenderer
    {
        private byte[] buffer;
        private int bufferPosition = 0;

        public TextRenderer()
        {
            buffer = new byte[1024];
            DrawHeader();
        }

        public void DrawRectangle(Rectangle rectangle)
        {
            var data = string.Format("Rectangle ({0},{1}) width={2} height={3}{4}", rectangle.PositionX, rectangle.PositionY, rectangle.Width, rectangle.Height, Environment.NewLine);
            WriteStringToBuffer(data);
        }
        public void DrawSquare(Square square)
        {
            var data = string.Format("Square ({0},{1}) size={2}{3}", square.PositionX, square.PositionY, square.Width, Environment.NewLine);
            WriteStringToBuffer(data);
        }

        public void DrawEllipse(Ellipse ellipse)
        {
            var data = string.Format("Ellipse ({0},{1}) diameterH = {2} diameterV = {3}{4}", ellipse.PositionX, ellipse.PositionY, ellipse.DiameterH, ellipse.DiameterV, Environment.NewLine);
            WriteStringToBuffer(data);
        }

        public void DrawCircle(Circle circle)
        {
            var data = string.Format("Circle ({0},{1}) size = {2}{3}", circle.PositionX, circle.PositionY, circle.Diameter, Environment.NewLine);
            WriteStringToBuffer(data);
        }

        public void DrawTextbox(Textbox textbox)
        {
            switch (textbox.Orientation)
            {
                case Orientation.HORIZONTAL:
                    var data = string.Format("Textbox ({0},{1}) width={2} height={3} text=\"{4}\"{5}", textbox.PositionX, textbox.PositionY, textbox.Width, textbox.Height, textbox.Text, Environment.NewLine);
                    WriteStringToBuffer(data);
                    break;
                default:
                    throw new NotSupportedException(nameof(textbox.Orientation));
            }
        }

        private void DrawHeader()
        {
            var data = string.Format("{0}{1}", FrameProvider.CanvasHeader, Environment.NewLine);
            WriteStringToBuffer(data);
        }

        private void DrawFooter()
        {
            WriteStringToBuffer(FrameProvider.CanvasFooter);
        }

        private void WriteStringToBuffer(string data)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            int writeSize = bytes.Length;
            int bytesAvailable = buffer.Length - bufferPosition;

            if (writeSize > bytesAvailable)
            {
                throw new OutOfMemoryException(string.Format("Tried to write {0} bytes to buffer, but only had {1} bytes remaining", bytes.Length, bytesAvailable));
            }

            bytes.CopyTo(buffer, bufferPosition);
            bufferPosition += bytes.Length;
        }

        public void Render(Stream stream)
        {
            DrawFooter();

            stream.Write(buffer, 0, bufferPosition);
        }

        public void Dispose()
        {
            Array.Clear(buffer, 0, buffer.Length);
            bufferPosition = 0;
        }
    }
}
