using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWarsShared.Enums;
using RobotWarsShared.Models;

namespace RobotWarsTest
{
    [TestClass]
    public class CollisionTests
    {
        [TestMethod]
        public void PreventCollisionWithOtherRobot()
        {
            Canvas canvas = new Canvas(5, 5);

            Point location = new Point(1, 1);
            Point location1 = new Point(1, 2);

            Direction direction = Direction.North;

            Robot robot = new Robot(location, direction);
            Robot robot1 = new Robot(location1, direction);

            canvas.AddRobot(robot);
            canvas.AddRobot(robot1);

            robot.HandleInput(new Input(new[] { Action.Move }));

            Assert.AreEqual(1, robot.Location.Y);
        }

        [TestMethod]
        public void PreventCollisionWithLeftBoundary()
        {
            Canvas canvas = new Canvas(5, 5);

            Point location = new Point(0, 5);

            Direction direction = Direction.West;

            Robot robot = new Robot(location, direction);

            canvas.AddRobot(robot);

            robot.HandleInput(new Input(new[] { Action.Move }));

            Assert.AreEqual(0, robot.Location.X);
        }

        [TestMethod]
        public void PreventCollisionWithRightBoundary()
        {
            Canvas canvas = new Canvas(5, 5);

            Point location = new Point(5, 5);

            Direction direction = Direction.East;

            Robot robot = new Robot(location, direction);

            canvas.AddRobot(robot);

            robot.HandleInput(new Input(new[] { Action.Move }));

            Assert.AreEqual(5, robot.Location.X);
        }

        [TestMethod]
        public void PreventCollisionWithUpperBoundary()
        {
            Canvas canvas = new Canvas(5, 5);

            Point location = new Point(0, 5);

            Direction direction = Direction.North;

            Robot robot = new Robot(location, direction);

            canvas.AddRobot(robot);

            robot.HandleInput(new Input(new[] { Action.Move }));

            Assert.AreEqual(5, robot.Location.Y);
        }

        [TestMethod]
        public void PreventCollisionWithBottomBoundary()
        {
            Canvas canvas = new Canvas(5, 5);

            Point location = new Point(0, 0);

            Direction direction = Direction.South;

            Robot robot = new Robot(location, direction);

            canvas.AddRobot(robot);

            robot.HandleInput(new Input(new[] { Action.Move }));

            Assert.AreEqual(0, robot.Location.Y);
        }
    }
}
