namespace ConsoleApplication.Interfaces
{
    using System.Xml.Linq;

    public interface IInstanceFactory
    {
        object Create(XElement element, string instanceFamily);
    }
}
