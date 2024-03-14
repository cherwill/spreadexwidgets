using Widgets.Enums;

namespace Widgets.Widgets
{
    public class Textbox : Rectangle
    {
        public Textbox(int positionX, int positionY, int width, int height, string text, Orientation orientation = Orientation.HORIZONTAL) : base(positionX, positionY, width, height)
        {
            this.Text = text;
            this.Orientation = orientation;
        }

        public string Text { get; set; }

        public Orientation Orientation { get; set; }
    }
}