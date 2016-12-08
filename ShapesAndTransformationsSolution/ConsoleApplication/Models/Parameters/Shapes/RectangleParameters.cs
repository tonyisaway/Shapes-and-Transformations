namespace ConsoleApplication.Models.Parameters.Shapes
{
    public class RectangleParameters : ShapeParameters
    {
        public RectangleParameters() : base("rectangle")
        {
        }

        public int LeftUpper { get; set; }
        public int LeftLower { get; set; }
        public int RightUpper { get; set; }
        public int RightLower { get; set; }
    }
}
