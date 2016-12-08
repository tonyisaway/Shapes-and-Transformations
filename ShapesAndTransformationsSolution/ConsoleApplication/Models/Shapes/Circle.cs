namespace ConsoleApplication.Models.Shapes
{
    using Interfaces;

    public class Circle
    {
        public Circle(ICoordinatePoint centrePoint, ICoordinatePoint radiusPoint)
        {
            CentreCoordinate = centrePoint;
            RadiusCoordinate = radiusPoint;
        }

        ICoordinatePoint CentreCoordinate { get; }
        ICoordinatePoint RadiusCoordinate { get; }
    }
}
