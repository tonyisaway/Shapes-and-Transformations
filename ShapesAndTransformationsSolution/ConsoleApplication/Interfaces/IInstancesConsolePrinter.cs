namespace ConsoleApplication.Interfaces
{
    using System.Collections.Generic;

    public interface IInstancesConsolePrinter
    {
        void Print(IEnumerable<object> objects);
    }
}
