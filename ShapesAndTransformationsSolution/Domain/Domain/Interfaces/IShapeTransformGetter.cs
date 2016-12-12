namespace Domain.Interfaces
{
    using System.Collections.Generic;

    public interface IShapeTransforGetter
    {
        INameWithNamedAttributes TransformGet(INameWithNamedAttributes shapesAttributes, 
            IEnumerable<INameWithNamedAttributes> transformsAttributes);
    }
}
