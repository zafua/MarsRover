using System;
using Hepsiburada.MarsRover.Enums;

namespace Hepsiburada.MarsRover.Rovers
{
    public class Face
    {
        public DirectionEnum CurrentFace { get; set; }

        public Face(char Face)
        {
            CurrentFace = (DirectionEnum)Face;
        }
    }
}
