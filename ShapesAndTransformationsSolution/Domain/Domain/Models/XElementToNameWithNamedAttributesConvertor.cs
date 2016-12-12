namespace Domain.Models
{
    using System.Xml.Linq;
    using Interfaces;
    using System.Collections.Generic;

    public class XElementToNameWithNamedAttributesConvertor : IXElementToNameWithNamedAttributesConvertor
    {
        public INameWithNamedAttributes Convert(XElement xelement)
        {
            var nameWithNamedAttributes = new NameWithNamedAttributes
            {

                Name = xelement.Name.LocalName
            };

            var attributes = new List<KeyValuePair<string, int>>();
            foreach (var attribute in xelement.Attributes())
            {
                int value;

                if (int.TryParse(attribute.Value, out value))
                {
                    var name = attribute.Name.LocalName;
                    var nameAndValue = new KeyValuePair<string, int>(name, value);
                    attributes.Add(nameAndValue);
                }
            }

            nameWithNamedAttributes.Attributes = attributes;

            return nameWithNamedAttributes;
        }
    }
}
