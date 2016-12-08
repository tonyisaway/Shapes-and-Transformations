namespace ConsoleApplication.Models
{
    using System.Xml.Linq;
    using Interfaces;
    using System.Reflection;
    using System;

    public class XmlObjectPopulator : IXElementObjectPopulator
    {
        public void Populate(XElement element, object obj)
        {
            var type = obj.GetType();
            foreach (var attribute in element.Attributes())
            {
                var property = type.GetProperty(attribute.Name.LocalName,
                    BindingFlags.SetProperty |
                    BindingFlags.IgnoreCase |
                    BindingFlags.Public |
                    BindingFlags.Instance);

                if (property == null)
                {
                    throw new InvalidOperationException(string.Format("{0} is not a valid value for {1}."
                        , attribute.Name.LocalName
                        , element.Name.LocalName));
                }

                int valueInt;
                if (!int.TryParse(attribute.Value, out valueInt))
                {
                    throw new InvalidOperationException(string.Format("{0} is not a valid value for {1}.{2}"
                        , attribute.Value
                        , attribute.Name.LocalName
                        , element.Name.LocalName));
                }

                property.SetValue(obj, valueInt, null);
            }
        }
    }
}
