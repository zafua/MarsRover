using Hepsiburada.MarsRover.Enums;

namespace Hepsiburada.MarsRover.Commands
{
    public class Command : ICommand
    {
        private CommandTypeEnum commandType;

        public Command(char command)
        {
            this.commandType = (CommandTypeEnum)command;
        }

        public CommandTypeEnum GetCommandType()
        {
            return commandType;
        }
    }
}
