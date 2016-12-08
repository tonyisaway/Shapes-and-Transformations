namespace ConsoleApplication.Models
{
    using Interfaces;
    using Parameters.Shapes;
    using Shapes;

    public class ShapeFactory : IShapeFactory
    {
        public IShape Create(IShapeParameters parameters)
        {
            
            if (parameters is CircleParameters)
            {
                var shapeParams = parameters as CircleParameters;
                var centrePoint = new CoordinatePoint(shapeParams.CentreX, shapeParams.CentreY);
                var radiusPoint = new CoordinatePoint(shapeParams.CentreX, shapeParams.CentreY + shapeParams.Radius);
                return new Circle(centrePoint, radiusPoint);
            }

            if (parameters is RectangleParameters)
            {
                var shapeParams = parameters as RectangleParameters;
                var topRightVertex = new CoordinatePoint(shapeParams.RightUpper, shapeParams.L);
                var bottomLeftVertex = new CoordinatePoint(shapeParams.CentreX, shapeParams.CentreY);
                return new Rectangle(topRightVertex, bottomLeftVertex);
            }

        }
    }
}
