using System;
using Hepsiburada.MarsRover.Rovers;

namespace Hepsiburada.MarsRover.Exceptions
{
    public class RoverOutOfLandException : Exception
    {
        public RoverOutOfLandException(IRover rover)
            : base (String.Format("Invalid Position for this land X: {0} Y: {1}",
                rover.Position.X, rover.Position.Y))
        {

        }
    }
}
