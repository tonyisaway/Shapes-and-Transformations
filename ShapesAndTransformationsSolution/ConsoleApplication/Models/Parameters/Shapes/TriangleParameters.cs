namespace ConsoleApplication.Models.Parameters.Shapes
{
    public class TriangleParameters : ShapeParameters
    {
        public TriangleParameters() : base("triangle")
        {
        }

        public int OneX { get; set; }
        public int OneY { get; set; }
        public int ThreeX { get; set; }
        public int ThreeY { get; set; }
        public int TwoX { get; set; }
        public int TwoY { get; set; }
    }
}
