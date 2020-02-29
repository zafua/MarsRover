using System;
using System.Collections.Generic;
using Hepsiburada.MarsRover;
using Hepsiburada.MarsRover.Commands;
using Hepsiburada.MarsRover.Exceptions;
using Hepsiburada.MarsRover.Land;
using Hepsiburada.MarsRover.Rovers;
using Xunit;

namespace Hepsiburada.MarsRoverTests
{
    public class UnitTests
    {
        [Fact]
        public void Test_LMLMLMLMM_Input()
        {
            Face face = new Face('N');
            Position position = new Position(1, 2);
            ILand land = new Mars(5, 5);
            IRover rover = new Rover(face, position, land);
            ICommandExecutor commandExecutor = new CommandExecutor();
            List<ICommand> commands = new List<ICommand>()
            {
                new Command('L'),
                new Command('M'),
                new Command('L'),
                new Command('M'),
                new Command('L'),
                new Command('M'),
                new Command('L'),
                new Command('M'),
                new Command('M')
            };

            Discovery discovery = new Discovery(rover, commands, commandExecutor);
            Assert.Equal("1 3 N", discovery.ToString());
        }

        [Fact]
        public void Test_MMRMMRMRRM_Input()
        {
            Face face = new Face('E');
            Position position = new Position(3, 3);
            ILand land = new Mars(5, 5);
            IRover rover = new Rover(face, position, land);
            ICommandExecutor commandExecutor = new CommandExecutor();
            List<ICommand> commands = new List<ICommand>()
            {
                new Command('M'),
                new Command('M'),
                new Command('R'),
                new Command('M'),
                new Command('M'),
                new Command('R'),
                new Command('M'),
                new Command('R'),
                new Command('R'),
                new Command('M')
            };

            Discovery discovery = new Discovery(rover, commands, commandExecutor);
            Assert.Equal("5 1 E", discovery.ToString());
        }

        [Fact]
        public void Test_NoDiscovery_Input()
        {
            Face face = new Face('E');
            Position position = new Position(3, 3);
            ILand land = new Mars(5, 5);
            IRover rover = new Rover(face, position, land);
            ICommandExecutor commandExecutor = new CommandExecutor();
            List<ICommand> commands = new List<ICommand>()
            {

            };

            Discovery discovery = new Discovery(rover, commands, commandExecutor);
            Assert.Equal("3 3 E", discovery.ToString());
        }

        [Fact]
        public void Test_OutOfLandException()
        {
            Face face = new Face('E');
            Position position = new Position(3, 3);
            ILand land = new Mars(5, 5);
            IRover rover = new Rover(face, position, land);
            ICommandExecutor commandExecutor = new CommandExecutor();
            List<ICommand> commands = new List<ICommand>()
            {

                new Command('M'),
                new Command('M'),
                new Command('M'),
                new Command('M'),
                new Command('M'),
                new Command('M'),
                new Command('M'),
                new Command('M'),
                new Command('M')
            };

            var exception = Record.Exception(() => new Discovery(rover, commands, commandExecutor));
            Assert.IsType(typeof(RoverOutOfLandException), exception);
        }
    }
}
