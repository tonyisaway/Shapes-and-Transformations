namespace ConsoleApplication.Models
{
    using System;
    using Interfaces;
    using System.Reflection;

    public class ObjectConsolePrinter : IObjectConsolePrinter
    {
        public void Print(object obj)
        {
            foreach (var prop in obj.GetType().GetProperties(BindingFlags.SetProperty 
                | BindingFlags.Public 
                | BindingFlags.Instance))
            {
                Console.WriteLine("{0} = {1}", prop.Name, prop.GetValue(obj, null));
            }
        }
    }
}
