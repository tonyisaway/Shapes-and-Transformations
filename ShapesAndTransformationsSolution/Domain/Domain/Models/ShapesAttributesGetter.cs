namespace Domain.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class ShapesAttributesGetter : IShapesAttributesGetter
    {
        public IEnumerable<IShapeAttributes> Get()
        {
            IEnumerable<IShapeAttributes> shapeAttributes = new List<IShapeAttributes>();
            return shapeAttributes;
        }
    }
}
