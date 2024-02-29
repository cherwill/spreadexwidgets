using System.Text;

namespace SpreadexWidgets.Widgets
{
    public class Square : Shape
    {
        public Square(int xPosition, int yPosition, int width) : base(xPosition, yPosition, width)
        {
            this.Width = width;
        }
    }
}