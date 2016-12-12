namespace Domain.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class ShapeTransformGetter : IShapeTransforGetter
    {
        IShapeCommandGetter shapeCommandGetter;
        IShapeVerticesGetter shapeVerticesGetter;
        IVerticiesToNameWithNamedAttributesConverter verticiesToNameWithNamedAttributesConverter;

        public ShapeTransformGetter(IShapeVerticesGetter shapeVerticesGetter, IShapeCommandGetter shapeCommandGetter, IVerticiesToNameWithNamedAttributesConverter verticiesToNameWithNamedAttributesConverter)
        {
            this.shapeVerticesGetter = shapeVerticesGetter;
            this.shapeCommandGetter = shapeCommandGetter;
            this.verticiesToNameWithNamedAttributesConverter = verticiesToNameWithNamedAttributesConverter;
        }

        public INameWithNamedAttributes TransformGet(INameWithNamedAttributes shapesAttributes
            , IEnumerable<INameWithNamedAttributes> transformsAttributes)
        {
            var transformed = shapeVerticesGetter.Get(shapesAttributes);
            foreach (var transformAttr in transformsAttributes)
            {
                var command = shapeCommandGetter.Get(transformAttr);
                command.Execute(transformed);
            }

            return verticiesToNameWithNamedAttributesConverter.Convert(transformed);
        }
    }
}
