namespace ConsoleApplication.Models.Parameters.Shapes
{
    public class SquareParameters : ShapeParameters
    {
        public SquareParameters() : base("square")
        {
        }

        public int Height { get; set; }
        public int LowerLeftX { get; set; }
        public int LowerLeftY { get; set; }
    }
}
