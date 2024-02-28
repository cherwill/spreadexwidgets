using SpreadexWidgets.Widgets;

namespace SpreadexWidgets.Renderers.V1
{
    internal interface IRenderer
    {
        void DrawRectangle(Rectangle rectangle);
        void DrawSquare(Square square);
        void DrawEllipse(Ellipse ellipse);
        void Render(Stream stream);
        void PurgeBuffer();
    }
}