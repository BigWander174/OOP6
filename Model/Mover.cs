namespace OOP6.Model
{
    internal class Mover
    {
        private Ball _ball;
        private Point _vector;
        private PictureBox _field;

        public Mover(Ball ball, PictureBox pictureBox)
        {
            _ball = ball;
            _field = pictureBox;
            _vector = new Point(1, 1);
        }

        public void Work()
        {
            var newPoint = AddPositionWhileUnBound();
            _ball.SetNewPosition(newPoint);
        }

        private Point AddPositionWhileUnBound()
        {
            var newPositionX = _ball.Position.X;
            if (_ball.Position.X < 0)
            {
                newPositionX = 1;
                _vector.X = -_vector.X;
            }
            else if (newPositionX + _ball.Radius > _field.Width)
            {
                newPositionX = _field.Width - _ball.Radius - 1;
                _vector.X = -_vector.X;
            }

            newPositionX += _vector.X;

            var newPositionY = _ball.Position.Y;
            if (_ball.Position.Y < 0)
            {
                newPositionY = 1;
                _vector.Y = -_vector.Y;
            }
            else if (newPositionY + _ball.Radius > _field.Height)
            {
                newPositionY = _field.Height - _ball.Radius - 1;
                _vector.Y = -_vector.Y;
            }
            newPositionY += _vector.Y;

            return new Point(newPositionX, newPositionY);
        }

        public void SetSpeed(int value)
        {
            int newX = value;
            int newY = value;
            if (_vector.X < 0)
            {
                newX = -newX;
            }
            if (_vector.Y < 0)
            {
                newY = -newY;
            }
            _vector = new Point(newX, newY);
        }
    }
}
