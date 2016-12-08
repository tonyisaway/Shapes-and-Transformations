namespace ConsoleApplication.Models.Shapes
{
    using Interfaces;
    using System;

    public class Rectangle : IShape
    {
        public Rectangle(ICoordinatePoint topRightVertex, ICoordinatePoint bottomLeftVertex)
        {
            TopRightVertex = topRightVertex;
            BottomLeftVertex = bottomLeftVertex;

            if (!((TopRightVertex.X == BottomRightVertex.X) && (BottomLeftVertex.X == TopLeftVertex.X)) 
                && ((TopRightVertex.Y == TopLeftVertex.Y) && (BottomLeftVertex.Y == BottomRightVertex.Y)))
            {
                throw new InvalidOperationException("Given coordiates are not valid for a rectangle.");
            }
        }

        ICoordinatePoint TopRightVertex { get; }
        ICoordinatePoint BottomRightVertex => new CoordinatePoint(TopRightVertex.X, BottomLeftVertex.Y);
        ICoordinatePoint BottomLeftVertex { get; }
        ICoordinatePoint TopLeftVertex => new CoordinatePoint(BottomLeftVertex.X, TopRightVertex.Y);
    }
}
