using SpreadexWidgets.Widgets;
using System.Text;

namespace SpreadexWidgets.Widgets
{
    public class Rectangle : Shape
    {
        private StringBuilder stringBuilder;
        private int height;
        public Rectangle(int xPosition, int yPosition, int width, int height) : base(xPosition, yPosition)
        {
            this.Width = width;
            this.Height = height;
            stringBuilder = new();
        }

        public int Height
        {
            get { return height; }
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value, nameof(value));
                height = value;
            }
        }

        public override string ToString()
        {
            stringBuilder.Clear();
            stringBuilder.AppendFormat("Rectangle ({0},{1}) width={2} height={3}", XPosition, YPosition, Width, Height);
            return stringBuilder.ToString();
        }
    }
}