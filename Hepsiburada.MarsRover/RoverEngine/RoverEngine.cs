using System.Collections.Generic;
using Hepsiburada.MarsRover.Commands;
using Hepsiburada.MarsRover.Exceptions;
using Hepsiburada.MarsRover.Rovers;

namespace Hepsiburada.MarsRover.RoverEngines
{
    public class RoverEngine : IRoverEngine
    {
        public IRover Rover { get; set; }
        private ICommandExecutor commandExecutor;

        public RoverEngine(IRover rover, ICommandExecutor commandExecutor)
        {
            this.Rover = rover;
            this.commandExecutor = commandExecutor;
        }

        public void Start(List<ICommand> Commands)
        {
            Commands.ForEach((command) =>
            {
                commandExecutor.Execute(Rover, command);

                if (!Rover.IsValid())
                    throw new RoverOutOfLandException(Rover);
            });

        }

    }
}
