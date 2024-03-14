using Widgets.Renderers.V1;
using Widgets.Widgets;

namespace Widgets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IRenderer renderer = new TextRenderer();

            renderer.DrawRectangle(new Rectangle(10, 10, 30, 40));
            renderer.DrawSquare(new Square(15, 30, 35));
            renderer.DrawEllipse(new Ellipse(100, 150, 300, 200));
            renderer.DrawCircle(new Circle(1, 1, 300));
            renderer.DrawTextbox(new Textbox(5, 5, 200, 100, "sample text"));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            using (StreamReader reader = new StreamReader(stream))
            {
                stream.Seek(0, SeekOrigin.Begin);
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}