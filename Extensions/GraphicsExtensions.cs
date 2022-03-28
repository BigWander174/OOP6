namespace OOP6.Extensions
{
    internal static class GraphicsExtensions
    {
        public static void DrawCircle(this Graphics graphics, SolidBrush color, Point position, int radius)
        {
            graphics.FillEllipse(color, position.X, position.Y, radius, radius);
        }
    }
}
