
using System.Collections.Generic;
using System.Text;
using Hepsiburada.MarsRover.Commands;
using Hepsiburada.MarsRover.RoverEngines;
using Hepsiburada.MarsRover.Rovers;

namespace Hepsiburada.MarsRover
{
    public class Discovery
    {
        private IRover Rover;
        private List<ICommand> Commands;

        public Discovery(IRover rover, List<ICommand> commands, ICommandExecutor commandExecutor)
        {
            Rover = rover;
            Commands = commands;
            IRoverEngine roverEngine = new RoverEngine(rover, commandExecutor);
            roverEngine.Start(Commands);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Rover.Position.X);
            sb.Append(" ");
            sb.Append(this.Rover.Position.Y);
            sb.Append(" ");
            sb.Append((char)this.Rover.Face.CurrentFace);
            return sb.ToString();
        }
    }
}
