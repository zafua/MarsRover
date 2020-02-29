using System;
using Hepsiburada.MarsRover.Exceptions;
using Hepsiburada.MarsRover.Land;

namespace Hepsiburada.MarsRover.Rovers
{
    public class Rover : IRover
    {
        public Face Face { get; set; }
        public Position Position { get; set; }
        private ILand Land;

        public Rover(Face face, Position position, ILand land)
        {
            Face = face;
            Position = position;
            Land = land;
        }


        public bool IsValid()
        {
            if (this.Position.CompareTo(Land.boundary) > 0)
                return false;
            if (this.Position.X < 0 || this.Position.Y < 0)
                return false;
            return true;
        }
    }
}
