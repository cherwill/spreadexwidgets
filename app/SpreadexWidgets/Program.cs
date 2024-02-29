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


// have a constructor for the textbox that has an extra argument - optional, alignment
// extend the rectangle for the textbox
// use the frame provider IN the renderer itself
// add the header to the constructor,
// add the footer to the render after it copies the buffer

// add switch statement to renderTextbox for the text alignment
// in the switch statement, if we hit DEFAULT, throw exception

// change consoleRenderer to textRenderer

using SpreadexWidgets.Renderers.V1;
using SpreadexWidgets.Widgets;
using System.IO;

namespace SpreadexWidgets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IRenderer renderer = new TextRenderer();
            renderer.DrawSquare(new Square(0, 0, 100));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            using (StreamReader reader = new StreamReader(stream))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }

            Console.ReadLine();
        }
    }
}