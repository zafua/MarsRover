using System;
using Hepsiburada.MarsRover.Rovers;

namespace Hepsiburada.MarsRover.Commands
{
    public interface ICommandExecutor
    {
        void Execute(IRover rover, ICommand command);
    }
}
