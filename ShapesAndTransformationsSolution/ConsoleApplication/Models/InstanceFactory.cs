namespace ConsoleApplication.Models
{
    using Interfaces;
    using System;
    using System.Xml.Linq;

    public class InstanceFactory : IInstanceFactory
    {
        IXElementObjectPopulator populator;

        public InstanceFactory(IXElementObjectPopulator populator)
        {
            this.populator = populator;
        }

        public object Create(XElement element, string instanceFamily)
        {
            var name = element.Name.LocalName;
            var type = Type.GetType(string.Format("ConsoleApplication.Models.Parameters.{0}.{1}Parameters", instanceFamily, name), false, true);

            if (type == null)
            {
                throw new InvalidOperationException(string.Format("{0} {1} not recognised.", instanceFamily, element.Name.LocalName));
            }

            var obj = Activator.CreateInstance(type);
            populator.Populate(element, obj);

            return obj;
        }
    }
}
