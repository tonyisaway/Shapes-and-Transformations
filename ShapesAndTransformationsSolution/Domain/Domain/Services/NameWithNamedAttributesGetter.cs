namespace Core.Services
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Xml.Linq;

    public class NameWithNamedAttributesGetter : INameWithNamedAttributesGetter
    {
        IFileContentsGetter shapesfileContentsGetter;
        IXElementToNameWithNamedAttributesConvertor xElementToShapeAttributesConvertor;

        public NameWithNamedAttributesGetter(IFileContentsGetter shapesfileContentsGetter, IXElementToNameWithNamedAttributesConvertor xElementToShapeAttributesConvertor)
        {
            this.shapesfileContentsGetter = shapesfileContentsGetter;
            this.xElementToShapeAttributesConvertor = xElementToShapeAttributesConvertor;
        }

        public IEnumerable<INameWithNamedAttributes> Get()
        {
            IList<INameWithNamedAttributes> shapesAttributes = new List<INameWithNamedAttributes>();

            var xmlString = shapesfileContentsGetter.Get();

            if (string.IsNullOrWhiteSpace(xmlString))
            {
                return shapesAttributes;
            }

            var xml = XElement.Parse(xmlString);

            foreach(var shapeXelement in xml.Elements())
            {
                var shapeAttributes = xElementToShapeAttributesConvertor.Convert(shapeXelement);
                shapesAttributes.Add(shapeAttributes);
            }

            return shapesAttributes;
        }
    }
}
