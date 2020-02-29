using System;
using Hepsiburada.MarsRover.Enums;

namespace Hepsiburada.MarsRover.Commands
{
    public interface ICommand
    {
        CommandTypeEnum GetCommandType();
    }
}
