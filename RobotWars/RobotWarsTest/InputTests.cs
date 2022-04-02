using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Services;
using RobotWarsShared.Enums;
using RobotWarsShared.Models;
using System.Collections.Generic;
using System.Linq;

namespace RobotWarsTest
{
    [TestClass]
    public class InputTests
    {
        [TestMethod]
        public void ParseMovesInputString()
        {
            InputService inputService = new InputService();
            string inputString = "MLR";

            List<Action> expected = new List<Action>() { Action.Move, Action.TurnLeft, Action.TurnRight };

            Input input = inputService.GetInputByString(inputString);

            Assert.IsTrue(expected.SequenceEqual(input.Actions));
        }

        [TestMethod]
        public void ParseBoundariesInputString()
        {
            InputService inputService = new InputService();
            string inputString = "5 5";

            Point expected = new Point(5, 5);

            Point point = inputService.GetTopCanvasBoundariesByString(inputString);

            Assert.IsTrue(point.Equals(expected));
        }

        [TestMethod]
        public void ParseRobotInputString()
        {
            InputService inputService = new InputService();
            string inputString = "5 5 N";

            Point robotLocation = new Point(5, 5);
            Robot expected = new Robot(robotLocation, Direction.North);

            Robot robot = inputService.GetRobotByString(inputString);

            Assert.IsTrue(robot.Location.Equals(expected.Location) &&
                          robot.Direction == expected.Direction);
        }
    }
}
