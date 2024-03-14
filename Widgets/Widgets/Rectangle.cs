namespace Widgets.Widgets
{
    public class Rectangle : Widget
    {
        private int height;
        public Rectangle(int xPosition, int yPosition, int width, int height) : base(xPosition, yPosition)
        {
            this.Width = width;
            this.Height = height;
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