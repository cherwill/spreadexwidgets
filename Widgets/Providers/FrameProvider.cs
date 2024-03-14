namespace Widgets.Providers
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
