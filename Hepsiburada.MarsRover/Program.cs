using System;
using System.Collections.Generic;
using System.Linq;
using Hepsiburada.MarsRover.Commands;
using Hepsiburada.MarsRover.Land;
using Hepsiburada.MarsRover.RoverEngines;
using Hepsiburada.MarsRover.Rovers;


namespace Hepsiburada.MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            ILand land = CreateLand();
            ICommandExecutor commandExecutor = new CommandExecutor();
            List<Discovery> lstDiscovery = new List<Discovery>();

            string read = Console.ReadLine();
            while (!String.IsNullOrEmpty(read))
            {
                IRover rover = CreateRover(land, read);
                List<ICommand> lstCommands = CreateCommands();
                lstDiscovery.Add(new Discovery(rover, lstCommands, commandExecutor));
                read = Console.ReadLine();
            }

            lstDiscovery.ForEach(item => Console.WriteLine(item.ToString()));

            Console.ReadLine();

        }

        static ILand CreateLand()
        {
            string[] v = Console.ReadLine().Split(' ');
            return new Mars(int.Parse(v[0]), int.Parse(v[1]));
        }

        static IRover CreateRover(ILand land, string read)
        {
            string[] v = read.Split(' ');
            return new Rover(new Face(v[2][0]), new Position(int.Parse(v[0]), int.Parse(v[1])), land);
        }

        static List<ICommand> CreateCommands()
        {
            List<ICommand> lstCommands = new List<ICommand>();
            Console.ReadLine().ToCharArray().ToList().ForEach((item) =>
            {
                lstCommands.Add(new Command(item));
            });

            return lstCommands;
        }
    }
}
