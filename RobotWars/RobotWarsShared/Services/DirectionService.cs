
using RobotWarsShared.Enums;

namespace RobotWarsShared.Services
{
    internal static class DirectionService
    {
        internal static Direction GetDirectionTurn(Direction currentDirection, bool turnLeft)
        {
            switch (currentDirection)
            {
                case Direction.North:
                    return turnLeft ? Direction.West : Direction.East;
                case Direction.South:
                    return turnLeft ? Direction.East : Direction.West;
                case Direction.West:
                    return turnLeft ? Direction.South : Direction.North;
                case Direction.East:
                    return turnLeft ? Direction.North : Direction.South;
                default:
                    throw new ArgumentOutOfRangeException(nameof(currentDirection));
            }
        }
    }
}
