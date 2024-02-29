namespace SpreadexWidgets.Widgets
{
    public class Widget
    {
        private int width;
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Widget(int positionX, int positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        public Widget(int xPosition, int yPosition, int width) : this(xPosition, yPosition)
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
