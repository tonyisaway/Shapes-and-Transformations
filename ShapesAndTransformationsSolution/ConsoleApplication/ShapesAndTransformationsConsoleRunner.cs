namespace ConsoleApplication
{
    using System;
    using Contracts;
    using Domain.Exceptions;

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