namespace ConsoleApplication.Models
{
    using Interfaces;
    using System;
    using System.Xml.Linq;

    public class XmlInstanceFactory : IInstanceFactory
    {
        IObjectPopulator populator;

        public XmlInstanceFactory(IObjectPopulator populator)
        {
            this.populator = populator;
        }

        public object Create(string xmlString, string instanceFamily)
        {
            var element = XElement.Parse(xmlString);
            var name = element.Name.LocalName;
            var type = Type.GetType(string.Format("ConsoleApplication.Models.Parameters.{0}.{1}Parameters", instanceFamily, name), false, true);

            if (type == null)
            {
                throw new InvalidOperationException(string.Format("{0} {1} not recognised.", instanceFamily, element.Name.LocalName));
            }

            var obj = Activator.CreateInstance(type);
            populator.Populate(element.ToString(), obj);

            return obj;
        }
    }
}
