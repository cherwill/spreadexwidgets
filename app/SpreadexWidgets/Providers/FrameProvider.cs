using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadexWidgets.Providers
{
    public class FrameProvider
    {
        private string canvasHeader = $"""
            ----------------------------------------------------------------
            Requested Drawing
            ----------------------------------------------------------------

            """;
        private string canvasFooter = $"""

            ----------------------------------------------------------------
            """;

        public string CanvasHeader { get { return canvasHeader; } }

        public string CanvasFooter { get { return canvasFooter; } }
    }
}
