using RobotWarsShared.Enums;

namespace RobotWarsShared.Models
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        internal Point AddPoint(Point point) =>
            new Point(X + point.X, Y + point.Y);

        internal static Point GetPointMoveResult(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return new Point(0, 1);
                case Direction.South:
                    return new Point(0, -1);
                case Direction.West:
                    return new Point(-1, 0);
                case Direction.East:
                    return new Point(1, 0);
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction));
            }
        }

        public bool Equals(Point other) =>
            X == other.X &&
            Y == other.Y;
    }
}
