using System.Drawing;

namespace OOP6.Model
{
    internal class Ball
    {
        private int _radius;
        private Point _position;

        public Ball (int radius, Point position)
        {
            _radius = radius;
            _position = position;
        }

        public Point Position => _position;
        public int Radius => _radius;

        internal void SetNewPosition(Point newPoint)
        {
            _position = newPoint;
        }
    }
}
