namespace Domain.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class VerticiesToNameWithNamedAttributesConverter : IVerticiesToNameWithNamedAttributesConverter
    {
        public INameWithNamedAttributes Convert(IEnumerable<IShapeVertex> shapeVertices)
        {
            return new NameWithNamedAttributes();
        }
    }
}
