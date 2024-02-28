using System;
using System.ComponentModel.DataAnnotations;

namespace SpreadexWidgets.Widgets
{
    public class Shape
    {
        private int width;
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public Shape(int xPosition, int yPosition)
        {
            this.XPosition = xPosition;
            this.YPosition = yPosition;
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
