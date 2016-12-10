namespace Domain.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class ShapeTransformationsAttributesGetter : IShapeTransformationsAttributesGetter
    {
        public IEnumerable<IShapeTransformationAttributes> Get()
        {
            var shapeTransformationsAttributes = new List<IShapeTransformationAttributes>();

            return shapeTransformationsAttributes;
        }
    }
}
