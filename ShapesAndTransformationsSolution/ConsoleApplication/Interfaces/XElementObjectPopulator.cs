namespace ConsoleApplication.Interfaces
{
    using System.Xml.Linq;

    public interface IXElementObjectPopulator
    {
        void Populate(XElement element, object obj);
    }
}