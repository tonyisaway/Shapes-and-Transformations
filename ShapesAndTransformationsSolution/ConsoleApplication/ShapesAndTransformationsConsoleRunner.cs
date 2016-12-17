namespace ConsoleApplication
{
    using Core.Interfaces;
    using Core.Services.Exceptions;
    using System;

    public class ShapesAndTransformationsConsoleRunner
    {
        IShapesAndTransformations shapesAndTransformations;

        public ShapesAndTransformationsConsoleRunner(IShapesAndTransformations shapesAndTransformations)
        {
            Console.WriteLine("Initialising Shapes and Transformations");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            if (shapesAndTransformations == null)
            {
                throw new ShapesAndTransformationsIsNullException();
            }

            this.shapesAndTransformations = shapesAndTransformations;
        }

        public void Run()
        {
            Console.WriteLine("Starting Run");
            Console.WriteLine();
            shapesAndTransformations.PrintShapes();
            shapesAndTransformations.TransformShapes();
            shapesAndTransformations.PrintShapes();
            Console.WriteLine("Finished Run");
            Console.WriteLine();
        }
    }
}