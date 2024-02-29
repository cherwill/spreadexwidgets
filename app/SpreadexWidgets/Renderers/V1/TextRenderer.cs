using SpreadexWidgets.Providers;
using SpreadexWidgets.Widgets;
using SpreadexWidgets.Enums;
using System.Text;

namespace SpreadexWidgets.Renderers.V1
{
    public class TextRenderer : IRenderer, IDisposable
    {
        private Stream buffer;

        public TextRenderer()
        {
            this.buffer = new MemoryStream();
            DrawHeader();
        }

        public void DrawRectangle(Rectangle rectangle)
        {
            var data = string.Format("Rectangle ({0},{1}) width={2} height={3}{4}", rectangle.PositionX, rectangle.PositionY, rectangle.Width, rectangle.Height, Environment.NewLine);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }
        public void DrawSquare(Square square)
        {
            var data = string.Format("Square ({0},{1}) size={2}{3}", square.PositionX, square.PositionY, square.Width, Environment.NewLine);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }

        public void DrawEllipse(Ellipse ellipse)
        {
            var data = string.Format("Ellipse ({0},{1}) diameterH = {2} diameterV = {3}{4}", ellipse.PositionX, ellipse.PositionY, ellipse.DiameterH, ellipse.DiameterV, Environment.NewLine);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }

        public void DrawCircle(Circle circle)
        {
            var data = string.Format("Circle ({0},{1}) size = {2}{3}", circle.PositionX, circle.PositionY, circle.Diameter, Environment.NewLine);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }

        public void DrawTextbox(Textbox textbox)
        {
            switch (textbox.Orientation)
            {
                case Orientation.HORIZONTAL:
                    var data = string.Format("Textbox ({0},{1}) width={2} height={3} text=\"{4}\"{5}", textbox.PositionX, textbox.PositionY, textbox.Width, textbox.Height, textbox.Text, Environment.NewLine);
                    byte[] bytes = Encoding.ASCII.GetBytes(data);
                    buffer.Write(bytes);
                    break;
                default:
                    throw new NotSupportedException(nameof(textbox.Orientation));
            }
        }

        private void DrawHeader()
        {
            var data = string.Format("{0}{1}", FrameProvider.CanvasHeader, Environment.NewLine);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }

        private void DrawFooter()
        {
            var data = FrameProvider.CanvasFooter;
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }

        public void Render(Stream stream)
        {
            DrawFooter();

            buffer.Seek(0, SeekOrigin.Begin);
            buffer.CopyTo(stream);
            stream.Seek(0, SeekOrigin.Begin);
        }

        public void Dispose()
        {
            buffer.Close();
        }
    }
}
