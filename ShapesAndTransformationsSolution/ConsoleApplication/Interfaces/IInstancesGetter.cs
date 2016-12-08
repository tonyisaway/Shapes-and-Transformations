namespace ConsoleApplication.Interfaces
{
    using System.Collections.Generic;
    using System.Xml.Linq;

    public interface IInstancesGetter
    {
        IReadOnlyCollection<object> GetAll(XElement xml);
    }
}
