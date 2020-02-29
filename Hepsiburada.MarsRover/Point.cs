using System;
namespace Hepsiburada.MarsRover
{
    public class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x; Y = y;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            Point comparePoint = obj as Point;
            if (comparePoint == null)
                throw new ArgumentException("Object is not a Point!");

            if (this.X > comparePoint.X || this.Y > comparePoint.Y)
                return 1;

            return 0;
        }
    }
}
