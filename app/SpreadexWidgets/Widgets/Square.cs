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
    }
}