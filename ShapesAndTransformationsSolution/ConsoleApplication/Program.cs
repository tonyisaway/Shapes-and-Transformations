namespace ConsoleApplication
{
    using System;
    using System.Xml.Linq;
    using Models;
    using System.Collections.Generic;
    using Interfaces;

    class Program
    {
        static void Main()
        {
           
            var shapes = GetShapes();

            PrintOut(shapes);

            var transformations = GetTransformations();

            PrintOut(transformations);

            TransformShapes(shapes);

            PrintOut(shapes);

            WaitBeforeClosingConsole();
        }

        static IEnumerable<object> GetShapes()
        {
            var xml = XElement.Load("App_Data/Shapes.xml");

            var g = new XmlInstancesGetter(new XmlInstanceFactory(new XmlInstancePopulator()));
            return g.GetAll(xml);
        }


        static IEnumerable<object> GetTransformations()
        {
            var xml = XElement.Load("App_Data/Transformations.xml");

            var g = new XmlInstancesGetter(new XmlInstanceFactory(new XmlInstancePopulator()));
            return g.GetAll(xml);
        }


        static void TransformShapes(IEnumerable<object> objs)
        {
            //var t = new MacroTransformer();
            //t.Transform();
        }

        static void PrintOut(IEnumerable<object> objs)
        {
            var p = new InstancesConsolePrinter(new InstanceConsolePrinter());
            p.Print(objs);
        }

        static void WaitBeforeClosingConsole()
        {
            Console.ReadLine();
        }
    }
}
