namespace SpreadexWidgets.Widgets
{
    public class Shape
    {
        private int width;
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Shape(int positionX, int positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        public Shape(int xPosition, int yPosition, int width) : this(xPosition, yPosition)
        {
            this.Width = width;
        }

        public int Width
        {
            get { return width; }
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value,nameof(value));
                width = value;
            }
        }
    }
}
