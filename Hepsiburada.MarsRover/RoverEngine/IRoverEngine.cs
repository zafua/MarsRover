using System;
using System.Collections.Generic;
using Hepsiburada.MarsRover.Commands;

namespace Hepsiburada.MarsRover.RoverEngines
{
    public interface IRoverEngine
    {
        void Start(List<ICommand> Commands);
    }
}
