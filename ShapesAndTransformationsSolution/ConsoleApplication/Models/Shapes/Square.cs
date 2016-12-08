namespace ConsoleApplication.Models.Shapes
{
    using Interfaces;
    using System;

    public class Square
    {
        public Square(ICoordinatePoint topRightVertex, ICoordinatePoint bottomLeftVertex)
        {
            TopRightVertex = topRightVertex;
            BottomLeftVertex = bottomLeftVertex;

            if (!(topRightVertex.Y + BottomRightVertex.Y == BottomRightVertex.X + BottomLeftVertex.X))
            {
                throw new InvalidOperationException("Given coordiates are not valid for a square.");
            }
        }

        ICoordinatePoint TopRightVertex { get; }
        ICoordinatePoint BottomRightVertex => new CoordinatePoint(TopRightVertex.X, BottomLeftVertex.Y);
        ICoordinatePoint BottomLeftVertex { get; }
        ICoordinatePoint TopLeftVertex => new CoordinatePoint(BottomLeftVertex.X, TopRightVertex.Y );
    }
}
