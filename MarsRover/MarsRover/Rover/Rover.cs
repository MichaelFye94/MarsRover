using System;
using System.Numerics;
using static MarsRover.Utils.Utils;

namespace MarsRover
{
    public class Rover
    {
        private Vector2 _position;
        private Vector2 _boundary;
        private Heading _heading;

        public Rover((int, int, string) position, Vector2 boundary)
        {
            _boundary = boundary;
            _position = Vector2.Clamp(new Vector2(position.Item1, position.Item2), Vector2.Zero, _boundary);
            Enum.TryParse(position.Item3, out _heading);
        }

        public string ProcessOrders(string orders)
        {
            foreach(var c in orders)
            {
                switch (c)
                {
                    case 'L':
                    case 'R':
                        Rotate(c);
                        break;
                    case 'M':
                        Move();
                        break;
                }
            }

            return transmitPosition();
        }

        public void Rotate(char direction)
        {
            var headingTransform = (int)(direction == 'L' ? _heading - 1 : _heading + 1);
            var newHeading = Mod(headingTransform, 4);
            _heading = (Heading)newHeading;
        }

        public void Move()
        {
            var forwardVector = ForwardVectors[_heading.ToString()];
            var newPosition = Vector2.Add(_position, forwardVector);
            _position = _position = Vector2.Clamp(newPosition, Vector2.Zero, _boundary);
        }

        private string transmitPosition()
            => $"{_position.X} {_position.Y} {_heading}";
    }
}
