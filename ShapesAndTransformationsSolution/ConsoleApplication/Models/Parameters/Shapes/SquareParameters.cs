namespace ConsoleApplication.Models.Parameters.Shapes
{
    public class SquareParameters : ShapeParameters
    {
        public SquareParameters() : base("square")
        {
        }

        public int Height { get; set; }
        public int LeftX { get; set; }
        public int LeftY { get; set; }
    }
}
