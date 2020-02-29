using System;
namespace Hepsiburada.MarsRover.Rover
{
    public interface IRoverFactory
    {
        IRover GetRover(Position startPosition, Face startFace);
    }
}
