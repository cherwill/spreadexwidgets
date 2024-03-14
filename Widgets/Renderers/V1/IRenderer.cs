using Widgets.Widgets;

namespace Widgets.Renderers.V1
{
    public interface IRenderer : IDisposable
    {
        void DrawRectangle(Rectangle rectangle);
        void DrawSquare(Square square);
        void DrawEllipse(Ellipse ellipse);
        void DrawCircle(Circle circle);
        void DrawTextbox(Textbox textbox);
        void Render(Stream stream);
    }
}