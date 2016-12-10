namespace Domain.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class ShapeVerticesGetter : IShapeVerticesGetter
    {
        public IEnumerable<IShapeVertex> Get()
        {
            var shapeVertices = new List<IShapeVertex>();

            return shapeVertices;
        }
    }
}
