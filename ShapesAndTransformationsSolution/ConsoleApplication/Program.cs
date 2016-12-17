namespace UI
{
    using Core.Services;
    using Infrastructure.Data;
    using System;
    using System.Configuration;
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

            var shapeVerticesGetter = new ShapeVerticesGetter();
            var shapeAttributesPrinter = new NameWithNamedAttributesConsolePrinter();

            var shapeCommandGetter = new ShapeCommandGetter();
            var shapeCommandsGetter = new ShapeCommandsGetter(shapeCommandGetter);
            var shapesAndTransformations = new ShapesAndTransformations(xmlShapesAttributesGetter
                , shapeVerticesGetter
                , shapeTransformationsAttributesGetter
                , shapeAttributesPrinter
                , shapeCommandsGetter);

            var app = new ShapesAndTransformationsConsoleRunner(shapesAndTransformations);

            app.Run();

            Console.ReadLine();
        }
    }
}
