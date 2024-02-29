using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadexWidgets.Providers
{
    public static class FrameProvider
    {
        private static string canvasHeader = $"""
            ----------------------------------------------------------------
            Requested Drawing
            ----------------------------------------------------------------
            """;
        private static string canvasFooter = $"""
            ----------------------------------------------------------------
            """;

        public static string CanvasHeader { get { return canvasHeader; } }

        public static string CanvasFooter { get { return canvasFooter; } }
    }
}
