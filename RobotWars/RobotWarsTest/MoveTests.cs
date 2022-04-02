using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWarsShared.Enums;
using RobotWarsShared.Models;

namespace RobotWarsTest
{
    [TestClass]
    public class MoveTests
    {
        [TestMethod]
        public void MoveLeftTest()
        {
            Canvas canvas = new Canvas(5, 5);
            Point location = new Point(1, 1);
            Direction direction = Direction.West;

            Robot robot = new Robot(location, direction);
            canvas.AddRobot(robot);

            robot.HandleInput(new Input(new[] { Action.Move }));

            Assert.AreEqual(0, robot.Location.X);
        }

        [TestMethod]
        public void MoveRightTest()
        {
            Canvas canvas = new Canvas(5, 5);
            Point location = new Point(1, 1);
            Direction direction = Direction.East;

            Robot robot = new Robot(location, direction);
            canvas.AddRobot(robot);

            robot.HandleInput(new Input(new[] { Action.Move }));

            Assert.AreEqual(2, robot.Location.X);
        }

        [TestMethod]
        public void MoveUpTest()
        {
            Canvas canvas = new Canvas(5, 5);
            Point location = new Point(1, 1);
            Direction direction = Direction.North;

            Robot robot = new Robot(location, direction);
            canvas.AddRobot(robot);

            robot.HandleInput(new Input(new[] { Action.Move }));

            Assert.AreEqual(2, robot.Location.Y);
        }

        [TestMethod]
        public void MoveDownTest()
        {
            Canvas canvas = new Canvas(5, 5);
            Point location = new Point(1, 1);
            Direction direction = Direction.South;

            Robot robot = new Robot(location, direction);
            canvas.AddRobot(robot);

            robot.HandleInput(new Input(new[] { Action.Move }));

            Assert.AreEqual(0, robot.Location.Y);
        }

        [TestMethod]
        public void RotateLeftTest()
        {
            Canvas canvas = new Canvas(5, 5);
            Point location = new Point(1, 1);
            Direction direction = Direction.North;
            Input turnLeft = new Input(new[] { Action.TurnLeft });

            Robot robot = new Robot(location, direction);
            canvas.AddRobot(robot);

            robot.HandleInput(turnLeft);

            Assert.AreEqual(Direction.West, robot.Direction);

            robot.HandleInput(turnLeft);

            Assert.AreEqual(Direction.South, robot.Direction);

            robot.HandleInput(turnLeft);

            Assert.AreEqual(Direction.East, robot.Direction);

            robot.HandleInput(turnLeft);

            Assert.AreEqual(Direction.North, robot.Direction);
        }

        [TestMethod]
        public void RotateRightTest()
        {
            Canvas canvas = new Canvas(5, 5);
            Point location = new Point(1, 1);
            Direction direction = Direction.North;
            Input turnRight = new Input(new[] { Action.TurnRight });

            Robot robot = new Robot(location, direction);
            canvas.AddRobot(robot);

            robot.HandleInput(turnRight);

            Assert.AreEqual(Direction.East, robot.Direction);

            robot.HandleInput(turnRight);

            Assert.AreEqual(Direction.South, robot.Direction);

            robot.HandleInput(turnRight);

            Assert.AreEqual(Direction.West, robot.Direction);

            robot.HandleInput(turnRight);

            Assert.AreEqual(Direction.North, robot.Direction);
        }
    }
}