using System.Data;

namespace SpreadexWidgets.Widgets
{
    public class Rectangle : Widget
    {
        List<int> widthChanges;
        List<int> heightChanges;

        private int height;
        public Rectangle(int xPosition, int yPosition, int width, int height) : base(xPosition, yPosition)
        {
            this.Width = width;
            this.Height = height;
            heightChanges = new();
            widthChanges = new();

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

        public void UpdateHeight(int newHeight)
        {
            if (heightChanges.Count == 0)
            {
                heightChanges.Add(Height);
            }
            heightChanges.Add(newHeight);
            Height = newHeight;
        }

        public void UpdateWidth(int newWidth)
        {
            widthChanges.Add(newWidth);
            Width = heightChanges[heightChanges.Count - 1];
        }

        public void revertHeightChange()
        {
            int length = heightChanges.Count - 1;

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));  
            }
            heightChanges.RemoveAt(length);

            length = heightChanges.Count - 1;

            if (length < 0)
            {
                throw new IndexOutOfRangeException(nameof(length));
            }

            Height = heightChanges[length];
        }

        public void revertWidthChange()
        {
            int length = widthChanges.Count - 1;

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }
            widthChanges.Remove(length);
        }
    }
}