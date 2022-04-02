namespace RobotWarsShared.Constants
{
    public class InputMap
    {
        public const string Move = "M";
        public const string RotateLeft = "L";
        public const string RotateRight = "R";

        public static Enums.Action GetActionByString(string input) =>
            input == Move ? Enums.Action.Move :
            input == RotateLeft ? Enums.Action.TurnLeft :
            input == RotateRight ? Enums.Action.TurnRight :
            throw new ArgumentOutOfRangeException(nameof(input));
    }
}
