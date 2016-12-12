namespace Domain.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class ShapeVerticesGetter : IShapeVerticesGetter
    {
        public IEnumerable<IShapeVertex> Get(INameWithNamedAttributes shapesAttributes)
        {
            var shapeVertices = new List<IShapeVertex>();

            return shapeVertices;
        }
    }
}
