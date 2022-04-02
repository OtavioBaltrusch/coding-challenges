using RobotWarsShared.Models;
using RobotWarsShared.Constants;
using RobotWarsShared.Services.Interfaces;
using RobotWarsShared.Enums;
using RobotWars.Constants;

namespace RobotWars.Services
{
    public class InputService : IInputService
    {
        public Input GetInputByString(string inputString)
        {
            char[] inputs = inputString.ToCharArray();

            return new Input(inputs.Select(i => InputMap.GetActionByString(i.ToString())));
        }

        public Point GetTopCanvasBoundariesByString(string inputString)
        {
            int[] inputs = inputString.Split(" ").Select(s => int.Parse(s)).ToArray();

            return new Point(inputs[0], inputs[1]);
        }

        public Robot GetRobotByString(string inputString)
        {
            string[] inputs = inputString.Split(" ");

            int[] coords = inputs.Take(2).Select(i => int.Parse(i)).ToArray();
            string directionString = inputs[2];

            Point location = new Point(coords[0], coords[1]);
            Direction direction = DirectionMap.GetDirectionByString(directionString);

            return new Robot(location, direction);
        }
    }
}
