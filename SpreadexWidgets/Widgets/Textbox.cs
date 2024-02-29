using SpreadexWidgets.Enums;

namespace SpreadexWidgets.Widgets
{
    public class Textbox : Rectangle
    {
        public Textbox(int xPosition, int yPosition, int width, int height, string text, Orientation orientation = Orientation.HORIZONTAL) : base(xPosition, yPosition, width, height)
        {
            this.Text = text;
            this.Orientation = orientation;
        }

        public string Text { get; set; }

        public Orientation Orientation { get; set; }
    }
}