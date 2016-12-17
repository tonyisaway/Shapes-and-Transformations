namespace Core.Interfaces
{
    using System.Collections.Generic;

    public interface IShapeVerticesGetter
    {
        IEnumerable<IShapeVertex> Get(INameWithNamedAttributes instructions);
    }
}
