namespace ConsoleApplication
{
    using Domain.Models;
    using System;
    using System.Configuration;
    using System.IO;
    using System.Xml.Linq;

    class Program
    {
        static void Main()
        {
            var xElement = XElement.Load("App_Data/Shapes.xml");

            var datastoreFolderPath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["DatastoreFolderPath"];

            var shapesAttributesFileName = ConfigurationManager.AppSettings["ShapesFileName"];
            var shapesfileContentsGetter = new FileContentsGetter(datastoreFolderPath + "/" + shapesAttributesFileName);
            var xElementToShapeAttributesConvertor = new XElementToNameWithNamedAttributesConvertor();
            var xmlShapesAttributesGetter = new NameWithNamedAttributesGetter(shapesfileContentsGetter, xElementToShapeAttributesConvertor);

            var transformationsAttributesFileName = ConfigurationManager.AppSettings["TransformationsFileName"];
            var transformationsfileContentsGetter = new FileContentsGetter(datastoreFolderPath + "/" + transformationsAttributesFileName);
            var xElementToTransformationsAttributesConvertor = new XElementToNameWithNamedAttributesConvertor();
            var shapeTransformationsAttributesGetter = new NameWithNamedAttributesGetter(transformationsfileContentsGetter, xElementToTransformationsAttributesConvertor);

            var shapeAttributesPrinter = new NameWithNamedAttributesConsolePrinter();

            var shapeVerticesGetter = new ShapeVerticesGetter();
            var shapeCommandGetter = new ShapeCommandGetter();
            var verticiesConvertor = new VerticiesToNameWithNamedAttributesConverter();
            var shapeTransformer = new ShapeTransformGetter(shapeVerticesGetter, shapeCommandGetter, verticiesConvertor);

            var shapesAndTransformations = new ShapesAndTransformations(xmlShapesAttributesGetter
                , shapeTransformationsAttributesGetter
                , shapeAttributesPrinter
                , shapeTransformer);

            var app = new ShapesAndTransformationsConsoleRunner(shapesAndTransformations);

            app.Run();

            Console.ReadLine();
        }
    }
}
