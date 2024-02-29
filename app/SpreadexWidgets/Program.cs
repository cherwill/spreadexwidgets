// TODO - add makefile to build, run the app, and run the tests
// TODO - change canvas to console renderer
// TODO - consider adding a flush to the renderer
// TODO - add a class in the middle to translate the shape to the renderer
// TODO - add abstraction to the way that shapes are rendered

// interface for renderer, and then add consolerenderer
// they both take the same shape, but they render it in different ways
// irenderer - add a render method, which returns a byte array or byte stream
// then you can use that to compare the known result
// equally, because its a byte array, it would work on ANY renderer

using SpreadexWidgets.Renderers.V1;
using SpreadexWidgets.Widgets;
using System.IO;

namespace SpreadexWidgets
{
    public class Program
    {
        public static void Main(string[] args)
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