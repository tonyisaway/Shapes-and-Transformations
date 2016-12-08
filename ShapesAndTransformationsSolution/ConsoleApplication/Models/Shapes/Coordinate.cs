namespace ConsoleApplication.Models.Shapes
{
    using Interfaces;

    public class CoordinatePoint : ICoordinatePoint
    {
        public CoordinatePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
