namespace Core.Services
{
    using Interfaces;
    using Models;
    using System.Collections.Generic;

    public class VerticiesToNameWithNamedAttributesConverter : IVerticiesToNameWithNamedAttributesConverter
    {
        public INameWithNamedAttributes Convert(IEnumerable<IShapeVertex> shapeVertices)
        {
            return new NameWithNamedAttributes();
        }
    }
}
