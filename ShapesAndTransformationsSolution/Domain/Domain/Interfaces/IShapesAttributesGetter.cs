namespace Domain.Interfaces
{
    using System.Collections.Generic;

    public interface IShapesAttributesGetter
    {
        IEnumerable<IShapeAttributes> Get();
    }
}
