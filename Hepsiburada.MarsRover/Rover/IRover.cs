using System;
namespace Hepsiburada.MarsRover.Rovers
{
    public interface IRover
    {
        Position Position { get; set; }
        Face Face { get; set; }
        bool IsValid();
    }
}
