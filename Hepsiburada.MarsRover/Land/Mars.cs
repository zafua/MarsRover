namespace Hepsiburada.MarsRover.Land
{
    public class Mars : ILand
    {
        public Boundary boundary { get; set; }

        public Mars(int x, int y)
        {
            boundary = new Boundary(x, y);
        }

    }
}
