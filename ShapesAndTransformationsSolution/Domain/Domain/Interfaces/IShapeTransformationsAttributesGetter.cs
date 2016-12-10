namespace Domain.Interfaces
{
    using System.Collections.Generic;

    public interface IShapeTransformationsAttributesGetter
    {
        IEnumerable<IShapeTransformationAttributes> Get();
    }
}
