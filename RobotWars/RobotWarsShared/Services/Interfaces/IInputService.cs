using RobotWarsShared.Models;

namespace RobotWarsShared.Services.Interfaces
{
    public interface IInputService
    {
        public Input GetInputByString(string inputString);
        public Point GetTopCanvasBoundariesByString(string inputString);
        public Robot GetRobotByString(string inputString);
    }
}
