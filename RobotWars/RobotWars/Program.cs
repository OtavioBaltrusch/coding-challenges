using Microsoft.Extensions.DependencyInjection;
using RobotWars.Services;
using RobotWarsShared.Services.Interfaces;

namespace RobotWars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection()
                .AddScoped<IInputService, InputService>()
                .AddScoped<RobotWarsService>()
                .BuildServiceProvider();

            var robotWarsService = serviceCollection.GetService<RobotWarsService>();

            Console.WriteLine("Welcome to robot wars, please enter the arena top boundaries:");

            string boundaries = Console.ReadLine();
            robotWarsService.Start(boundaries);

            Console.WriteLine("Please type the number of robots participating in the game:");
            int noRobots = int.Parse(Console.ReadLine());

            for (int i = 0; i < noRobots; i++)
            {
                Console.WriteLine("Please enter the robot's location and direction:");
                string robot = Console.ReadLine();

                robotWarsService.AddRobot(robot);
            }

            int iRobots = 0;
            foreach (var robot in robotWarsService.GetRobots())
            {
                iRobots++;

                Console.WriteLine($"Enter instructions for robot {iRobots}:");
                string instructions = Console.ReadLine();

                Console.WriteLine(robotWarsService.HandleInput(instructions, robot));
            }
        }
    }
}