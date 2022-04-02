using RobotWarsShared.Enums;

namespace RobotWars.Constants
{
    internal class DirectionMap
    {
        public static string GetDirectionByEnum(Direction direction) =>
            direction == Direction.North ? "N" :
            direction == Direction.South ? "S" :
            direction == Direction.West ? "W" :
            direction == Direction.East ? "E" :
            throw new ArgumentOutOfRangeException(nameof(direction));

        public static Direction GetDirectionByString(string direction) =>
            direction == "N" ? Direction.North :
            direction == "S" ? Direction.South :
            direction == "W" ? Direction.West :
            direction == "E" ? Direction.East :
            throw new ArgumentOutOfRangeException(nameof(direction));
    }
}
