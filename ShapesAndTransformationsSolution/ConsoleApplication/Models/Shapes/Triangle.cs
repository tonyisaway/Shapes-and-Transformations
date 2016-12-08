namespace ConsoleApplication.Models.Shapes
{
    using Interfaces;

    public class Triangle : IShape
    {
        public Triangle(ICoordinatePoint firstVertex, ICoordinatePoint secondVertex, ICoordinatePoint thirdVertex)
        {
            FirstVertex = firstVertex;
            SecondVertex = secondVertex;
            ThirdVertex = thirdVertex;
        }

        ICoordinatePoint FirstVertex { get; }
        ICoordinatePoint SecondVertex { get; }
        ICoordinatePoint ThirdVertex { get; }
    }
}
