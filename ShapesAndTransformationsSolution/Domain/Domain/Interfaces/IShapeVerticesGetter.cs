namespace Domain.Interfaces
{
    using System.Collections.Generic;

    public interface IShapeVerticesGetter
    {
        IEnumerable<IShapeVertex> Get(INameWithNamedAttributes shapesAttributes);
    }
}
