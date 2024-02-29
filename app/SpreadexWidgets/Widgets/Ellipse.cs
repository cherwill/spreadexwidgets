namespace SpreadexWidgets.Widgets
{
    public class Ellipse : Shape
    {
        private int diameterH;
        private int diameterV;
        public Ellipse(int xPosition, int yPosition, int diameterH, int diameterV) : base(xPosition, yPosition)
        {
            this.DiameterH = diameterH;
            this.DiameterV = diameterV;
        }

        public int DiameterH
        {
            get { return diameterH; }
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value, nameof(value));
                diameterH = value;
            }
        }

        public int DiameterV
        {
            get { return diameterV; }
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value, nameof(value));
                diameterV = value;
            }
        }
    }
}