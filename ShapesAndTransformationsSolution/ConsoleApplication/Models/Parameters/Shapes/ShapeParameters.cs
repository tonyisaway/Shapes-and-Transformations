namespace ConsoleApplication.Models.Parameters.Shapes
{
    using Interfaces;

    public abstract class ShapeParameters : IShapeParameters
    {
        internal ShapeParameters(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
