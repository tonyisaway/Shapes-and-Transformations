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

        public ShapesAndTransformations(IShapesAttributesGetter shapesAttributesGetter, IShapeVerticesGetter shapesVerticesGetter, IShapeTransformationsAttributesGetter shapeTransformationsAttributesGetter)
        {
            // TODO: These cannot be null
            this.shapesAttributesGetter = shapesAttributesGetter;
            this.shapesVerticesGetter = shapesVerticesGetter;
            this.shapeTransformationsAttributesGetter = shapeTransformationsAttributesGetter;
        }

        public void LoadShapes()
        {
            var shapeAttributes = shapesAttributesGetter.Get();
            Console.WriteLine("Loading shapes");
        }

        public void LoadTransforms()
        {
            var shapeTransformationAttributes = shapeTransformationsAttributesGetter.Get();
            Console.WriteLine("Loading transforms");
        }

        public void PrintShapes()
        {
            Console.WriteLine("Printing shapes");
        }

        public void TransformShapes()
        {
            var shapeVertices = shapesVerticesGetter.Get();
            Console.WriteLine("Transforming shapes");
        }
    }
}