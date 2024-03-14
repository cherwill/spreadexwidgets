namespace Widgets.Widgets
{
    public class Square : Widget
    {
        public Square(int xPosition, int yPosition, int width) : base(xPosition, yPosition)
        {
            this.Width = width;
        }
    }
}