namespace ConsoleApplication.Models.Parameters.Shapes
{
    public class CircleParameters : ShapeParameters
    {
        public CircleParameters() : base("circle")
        {
        }

        public int CentreX { get; set; }
        public int CentreY { get; set; }
        public int Radius { get; set; }
    }
}
