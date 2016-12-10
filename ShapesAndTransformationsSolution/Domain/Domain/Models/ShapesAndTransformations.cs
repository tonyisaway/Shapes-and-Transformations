namespace Domain.Models
{
    using System;
    using Contracts;
    using Interfaces;

    public class ShapesAndTransformations : IShapesAndTransformations
    {
        IShapesAttributesGetter shapesAttributesGetter;
        IShapeVerticesGetter shapesVerticesGetter;
        IShapeTransformationsAttributesGetter shapeTransformationsAttributesGetter;
        IShapeAttributesPrinter shapeAttributesPrinter;
        IShapeTransformer shapeTransformer;

        public ShapesAndTransformations(IShapesAttributesGetter shapesAttributesGetter
            , IShapeVerticesGetter shapesVerticesGetter
            , IShapeTransformationsAttributesGetter shapeTransformationsAttributesGetter
            , IShapeAttributesPrinter shapeAttributesPrinter
            , IShapeTransformer shapeTransformer)
        {
            // TODO: These cannot be null
            this.shapesAttributesGetter = shapesAttributesGetter;
            this.shapesVerticesGetter = shapesVerticesGetter;
            this.shapeTransformationsAttributesGetter = shapeTransformationsAttributesGetter;
            this.shapeAttributesPrinter = shapeAttributesPrinter;
            this.shapeTransformer = shapeTransformer;
        }

        public void LoadShapes()
        {
            Console.WriteLine("Loading shapes");
            var shapeAttributes = shapesAttributesGetter.Get();
        }

        public void LoadTransforms()
        {
            Console.WriteLine("Loading transforms");
            var shapeTransformationAttributes = shapeTransformationsAttributesGetter.Get();
        }

        public void PrintShapes()
        {
            Console.WriteLine("Printing shapes");
            shapeAttributesPrinter.Print();
        }

        public void TransformShapes()
        {
            Console.WriteLine("Transforming shapes");
            var shapeVertices = shapesVerticesGetter.Get();
            shapeTransformer.Transform();
        }
    }
}