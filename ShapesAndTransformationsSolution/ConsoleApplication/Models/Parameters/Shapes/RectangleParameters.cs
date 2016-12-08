namespace ConsoleApplication.Models.Parameters.Shapes
{
    public class RectangleParameters : ShapeParameters
    {
        public RectangleParameters() : base("rectangle")
        {
        }

        public int LowerLeftX { get; set; }
        public int LowerLeftY { get; set; }
        public int UpperRightX { get; set; }
        public int UpperRightY { get; set; }
    }
}
