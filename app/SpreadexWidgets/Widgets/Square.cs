using SpreadexWidgets.Widgets;
using System.Text;

namespace SpreadexWidgets.Widgets
{
    public class Square : Shape
    {
        private StringBuilder stringBuilder;
        public Square(int xPosition, int yPosition, int width) : base(xPosition, yPosition, width)
        {
            this.Width = width;
            stringBuilder = new();
        }

        public override string ToString()
        {
            stringBuilder.Clear();
            stringBuilder.AppendFormat("Square ({0},{1}) size={2}", XPosition, YPosition, Width);
            return stringBuilder.ToString();
        }
    }
}