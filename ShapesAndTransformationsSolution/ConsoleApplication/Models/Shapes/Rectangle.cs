namespace ConsoleApplication.Models.Shapes
{
    using Interfaces;
    using System;

    public class Rectangle : IShape
    {
        public Rectangle(ICoordinatePoint upperRightVertex, ICoordinatePoint lowerLeftVertex)
        {
            UpperRightVertex = upperRightVertex;
            LowerLeftVertex = lowerLeftVertex;

            if (!((UpperRightVertex.X == LowerRightVertex.X) && (LowerLeftVertex.X == UpperLeftVertex.X)) 
                && ((UpperRightVertex.Y == UpperLeftVertex.Y) && (LowerLeftVertex.Y == LowerRightVertex.Y)))
            {
                throw new InvalidOperationException("Given coordiates are not valid for a rectangle.");
            }
        }

        ICoordinatePoint UpperRightVertex { get; }
        ICoordinatePoint LowerRightVertex => new CoordinatePoint(UpperRightVertex.X, LowerLeftVertex.Y);
        ICoordinatePoint LowerLeftVertex { get; }
        ICoordinatePoint UpperLeftVertex => new CoordinatePoint(LowerLeftVertex.X, UpperRightVertex.Y);
    }
}
