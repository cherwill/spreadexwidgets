using SpreadexWidgets.Widgets;
using System.Text;

namespace SpreadexWidgets.Renderer
{
    public class Canvas
    {
        private StringBuilder stringBuilder;
        private List<Shape> shapes;
        private string canvasHeader = $"""
            ----------------------------------------------------------------
            Requested Drawing
            ----------------------------------------------------------------

            """;
        private string canvasFooter = $"""

            ----------------------------------------------------------------
            """;

        public Canvas(List<Shape> shapes)
        {
            this.shapes = shapes;
            stringBuilder = new();
        }

        public List<Shape> Shapes { get { return shapes; } }

        public string CanvasHeader { get { return canvasHeader; } }

        public string CanvasFooter { get { return canvasFooter; } }

        private string ShapesAsString()
        {
            return string.Join(Environment.NewLine, Shapes);
        }

        public string Render()
        {
            stringBuilder.Clear();

            stringBuilder.Append(canvasHeader);
            stringBuilder.Append(ShapesAsString());
            stringBuilder.Append(canvasFooter);

            return stringBuilder.ToString();
        }
    }
}
