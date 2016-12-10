namespace ConsoleApplication
{
    using Domain.Models;
    using System;
    using System.Xml.Linq;

    class Program
    {
        static void Main()
        {
            var xElement = XElement.Load("App_Data/Shapes.xml");


            var shapesAttributesGetter = new ShapesAttributesGetter();
            var shapesVerticesGetter = new ShapeVerticesGetter();
            var shapeTransformationsAttributesGetter = new ShapeTransformationsAttributesGetter();
            var shapeAttributesPrinter = new ShapeAttributesPrinter();
            var shapeTransformer = new ShapeTransformer();
            var shapesAndTransformations = new ShapesAndTransformations(shapesAttributesGetter
                , shapesVerticesGetter
                , shapeTransformationsAttributesGetter
                , shapeAttributesPrinter
                , shapeTransformer);

            var app = new ShapesAndTransformationsConsoleRunner(shapesAndTransformations);

            app.Run();

            Console.ReadLine();
        }
    }
}
