using RobotWars.Constants;
using RobotWarsShared.Models;
using RobotWarsShared.Services.Interfaces;

namespace RobotWars.Services
{
    public class RobotWarsService
    {
        private IInputService inputService;
        private Canvas canvas;

        public RobotWarsService(IInputService inputService)
        {
            this.inputService = inputService;
        }

        public void Start(string boundaries)
        {
            canvas = new Canvas(inputService.GetTopCanvasBoundariesByString(boundaries));
        }

        public void AddRobot(string robotString)
        {
            canvas.AddRobot(inputService.GetRobotByString(robotString));
        }

        public List<Robot> GetRobots() =>
            canvas.Robots;

        public string HandleInput(string inputString, Robot robot)
        {
            if (!canvas.Robots.Contains(robot)) throw new ArgumentOutOfRangeException(nameof(robot));

            Input input = inputService.GetInputByString(inputString);
            robot.HandleInput(input);

            return GetFormattedRobotDetails(robot);
        }

        private string GetFormattedRobotDetails(Robot robot) =>
            $"{robot.Location.X} {robot.Location.Y} {DirectionMap.GetDirectionByEnum(robot.Direction)}";
    }
}
