namespace RobotWarsShared.Models
{
    public class Canvas
    {
        public int XBoundary { get; set; }
        public int YBoundary { get; set; }
        public List<Robot> Robots { get; }

        public Canvas(int xBoundary, int yBoundary)
        {
            XBoundary = xBoundary;
            YBoundary = yBoundary;
            Robots = new List<Robot>();
        }

        public Canvas(Point boundaries) : this(boundaries.X, boundaries.Y)
        {
        }

        public void AddRobot(Robot robot)
        {
            robot.Canvas = this;
            Robots.Add(robot);
        }

        internal bool CanMoveToPoint(Point point)
        {
            bool isWithinBoundaries = point.X <= XBoundary &&
                                      point.Y <= YBoundary &&
                                      point.X >= 0 &&
                                      point.Y >= 0;
            bool collision = Robots.Any(r => r.Location.Equals(point));

            return (isWithinBoundaries && !collision);
        }
    }
}
