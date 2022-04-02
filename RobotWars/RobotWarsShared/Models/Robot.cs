namespace RobotWarsShared.Models
{
    using RobotWarsShared.Enums;
    using RobotWarsShared.Services;

    public class Robot
    {
        public Point Location { get; set; }
        public Direction Direction { get; set; }
        public Canvas Canvas { get; set; }

        public Robot(Point initialLocation, Direction direction)
        {
            Direction = direction;
            Location = initialLocation;
        }

        public void HandleInput(Input input)
        {
            foreach (Action action in input.Actions)
                DoAction(action);
        }

        private void DoAction(Action action)
        {
            switch (action)
            {
                case Action.Move:
                    Point moveAction = Point.GetPointMoveResult(Direction);
                    Point destination = Location.AddPoint(moveAction);

                    if (Canvas.CanMoveToPoint(destination))
                        Location = destination;

                    break;
                case Action.TurnLeft:
                    Direction = DirectionService.GetDirectionTurn(Direction, true);

                    break;
                case Action.TurnRight:
                    Direction = DirectionService.GetDirectionTurn(Direction, false);

                    break;
                default:
                    throw new ArgumentException(nameof(action));
            }
        }
    }
}
