namespace Core.Interfaces
{
    using System.Collections.Generic;

    public interface IVerticiesToNameWithNamedAttributesConverter
    {
        INameWithNamedAttributes Convert(IEnumerable<IShapeVertex> shapeVertices);
    }
}
