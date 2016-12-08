namespace ConsoleApplication.Models
{
    using Interfaces;
    using System;
    using System.Xml.Linq;

    public class ShapeTransformationFactory
    {
        //public ITransform Create(XElement element, IShape shape)
        //{
        //    var name = element.Name.LocalName;
        //    var type = Type.GetType("ConsoleApplication.Models" + ".Xml" + name, false, true);

        //    if (type == null)
        //    {
        //        // throw new InvalidOperationException(string.Format("Shape {0} not recognised.", name));
        //        return new XmlShape(name);
        //    }

        //    var xmlShape = (IXmlShape)Activator.CreateInstance(type);

        //    if (xmlShape == null)
        //    {
        //        return new XmlShape(name);
        //    }

        //    populator.Populate(element, xmlShape);

        //    return xmlShape;
        //}
    }
}
