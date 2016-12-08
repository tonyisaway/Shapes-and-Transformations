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
                var upperRightVertex = new CoordinatePoint(shapeParams.UpperRightX, shapeParams.UpperRightY);
                var lowerLeftVertex = new CoordinatePoint(shapeParams.LowerLeftX, shapeParams.LowerLeftY);
                return new Rectangle(upperRightVertex, lowerLeftVertex);
            }

            if (parameters is SquareParameters)
            {
                var shapeParams = parameters as SquareParameters;
                var lowerLeftVertex = new CoordinatePoint(shapeParams.LowerLeftX, shapeParams.LowerLeftY);
                var upperRightVertex = new CoordinatePoint(shapeParams.LowerLeftX + shapeParams.Height, shapeParams.LowerLeftY + shapeParams.Height);
                return new Square(upperRightVertex, lowerLeftVertex);
            }

            if (parameters is TriangleParameters)
            {
                var shapeParams = parameters as TriangleParameters;
                var firstVertex = new CoordinatePoint(shapeParams.OneX, shapeParams.OneY);
                var secondVertex = new CoordinatePoint(shapeParams.TwoX, shapeParams.TwoY);
                var thirdVertex = new CoordinatePoint(shapeParams.ThreeX, shapeParams.ThreeY);
                return new Triangle(firstVertex, secondVertex, thirdVertex);
            }

            throw new System.Exception();
        }
    }
}
