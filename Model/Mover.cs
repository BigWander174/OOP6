using OOP6.Model;

namespace OOP6.Model
{
    internal class Mover
    {
        private Ball _ball;
        private Point _vector;
        private PictureBox _field;
        public Mover(Ball ball, PictureBox field)
        {
            _ball = ball;
            _field = field;
            _vector = new Point(1, 1);
        }

        public int NewPositionX => _ball.Position.X + _vector.X;
        public int NewPositionY => _ball.Position.Y + _vector.Y;

        public void Work()
        {
            CalculateDirection();
            _ball.SetNewPosition(NewPositionX + _vector.X, NewPositionY + _vector.Y);
        }

        private void CalculateDirection()
        {
            if (NewPositionX < 0 || NewPositionX + _ball.Radius > _field.Width)
            {
                _vector.X = -_vector.X;
            }
            if (NewPositionY < 0 || NewPositionY + _ball.Radius > _field.Height)
            {
                _vector.Y = -_vector.Y;
            }
        }
    }
}
