using SpreadexWidgets.Providers;
using SpreadexWidgets.Widgets;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SpreadexWidgets.Renderers.V1
{
    public class TextRenderer : IRenderer, IDisposable
    {
        private Stream buffer;

        public TextRenderer()
        {
            this.buffer = new MemoryStream(); // TODO - add limit to memory

            DrawHeader();
        }

        public void DrawRectangle(Rectangle rectangle)
        {
            var data = string.Format("Rectangle ({0},{1}) width={2} height={3}\r\n", rectangle.PositionX, rectangle.PositionY, rectangle.Width, rectangle.Height, Environment.NewLine);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }
        public void DrawSquare(Square square)
        {
            var data = string.Format("Square ({0},{1}) size={2}\r\n", square.PositionX, square.PositionY, square.Width);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }

        public void DrawEllipse(Ellipse ellipse)
        {
            var data = string.Format("Ellipse ({0},{1}) diameterH = {2} diameterV = {3}\r\n", ellipse.PositionX, ellipse.PositionY, ellipse.DiameterH, ellipse.DiameterV);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }

        public void DrawCircle(Circle circle)
        {
            var data = string.Format("Circle ({0},{1}) size = {2}\r\n", circle.PositionX, circle.PositionY, circle.Diameter);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }

        public void DrawTextbox(Textbox textbox)
        {
            var data = string.Format("Textbox ({0},{1}) width={2} height={3} text=\"{4}\"\r\n", textbox.PositionX, textbox.PositionY, textbox.Width, textbox.Height, textbox.Text);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            buffer.Write(bytes);
        }

        private void DrawHeader()
        {
            var data = string.Format("{0}\r\n", FrameProvider.CanvasHeader);
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
