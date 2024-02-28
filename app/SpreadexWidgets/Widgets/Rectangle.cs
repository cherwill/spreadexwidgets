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
    }
}