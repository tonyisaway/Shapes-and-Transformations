namespace ConsoleApplication.Models.Parameters.Shapes
{
    using Interfaces;

    public class ShapeParameters : IShape
    {
        public ShapeParameters(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
