using SpreadexWidgets.Enums;

namespace SpreadexWidgets.Widgets
{
    public class Textbox : Rectangle
    {
        private Orientation orientation;

        public Textbox(int xPosition, int yPosition, int width, int height, string text, Orientation orientation = Orientation.LEFT) : base(xPosition, yPosition, width, height)
        {
            this.Text = text;
            this.orientation = orientation;
        }



        public string Text { get; set; }

        public Orientation Orientation { get; set; }
    }
}