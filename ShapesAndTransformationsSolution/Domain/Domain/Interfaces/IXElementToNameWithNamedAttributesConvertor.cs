namespace Core.Interfaces
{
    using System.Xml.Linq;

    public interface IXElementToNameWithNamedAttributesConvertor
    {
        INameWithNamedAttributes Convert(XElement shapeXelement);
    }
}
