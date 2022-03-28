using OOP6.Extensions;

namespace OOP6.Model
{
    internal class Drawer
    {
        private Graphics _canvas;
        private Ball _target;
        private SolidBrush _brush;

        public Drawer(Graphics canvas, Ball ball)
        {
            _canvas = canvas;
            _target = ball;
            _brush = new SolidBrush(Color.Red);
        }

        public void Work()
        {
            _canvas.Clear(Color.White);
            _canvas.DrawCircle(_brush, _target.Position, _target.Radius);
        }

    }
}
