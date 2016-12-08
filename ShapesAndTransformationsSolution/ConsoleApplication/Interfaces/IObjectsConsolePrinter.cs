namespace ConsoleApplication.Interfaces
{
    using System.Collections.Generic;

    public interface IObjectsConsolePrinter
    {
        void Print(IEnumerable<object> objects);
    }
}
