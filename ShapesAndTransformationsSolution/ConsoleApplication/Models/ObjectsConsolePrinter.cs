namespace ConsoleApplication.Models
{
    using System.Collections.Generic;
    using Interfaces;
    using System;

    public class ObjectsConsolePrinter : IObjectsConsolePrinter
    {
        IObjectConsolePrinter objPrinter;
        public ObjectsConsolePrinter(IObjectConsolePrinter objPrinter)
        {
            this.objPrinter = objPrinter;
        }
        public void Print(IEnumerable<object> objects)
        {
            foreach(var o in objects)
            {
                objPrinter.Print(o);
                Console.WriteLine();
            }
        }
    }
}
