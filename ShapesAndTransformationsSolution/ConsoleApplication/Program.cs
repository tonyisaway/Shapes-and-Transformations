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

            var shapesAndTransformations = new ShapesAndTransformations(shapesAttributesGetter, shapesVerticesGetter, shapeTransformationsAttributesGetter);

            var app = new ShapesAndTransformationsConsoleRunner(shapesAndTransformations);

            app.Run();

            Console.ReadLine();
        }
    }
}
