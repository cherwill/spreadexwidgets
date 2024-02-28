using SpreadexWidgets.Widgets;
using System.Text;

namespace SpreadexWidgets.Widgets
{
    public class Ellipse : Shape
    {
        private StringBuilder stringBuilder;
        private int diameterH;
        private int diameterV;
        public Ellipse(int xPosition, int yPosition, int diameterH, int diameterV) : base(xPosition, yPosition)
        {
            this.DiameterH = diameterH;
            this.DiameterV = diameterV;

            stringBuilder = new();
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

        public override string ToString()
        {
            stringBuilder.Clear();
            stringBuilder.AppendFormat("Ellipse ({0},{1}) diameterH = {2} diameterV = {3}", XPosition, YPosition, diameterH, diameterV);
            return stringBuilder.ToString();
        }
    }
}