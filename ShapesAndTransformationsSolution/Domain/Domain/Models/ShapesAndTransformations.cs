namespace Domain.Models
{
    using System;
    using Contracts;
    using Interfaces;
    using System.Collections.Generic;

    public class ShapesAndTransformations : IShapesAndTransformations
    {
        INameWithNamedAttributesGetter shapesAttributesGetter;
        IShapeVerticesGetter shapesVerticesGetter;
        INameWithNamedAttributesGetter transformationsAttributesGetter;
        INameWithNamedAttributesConsolePrinter shapeAttributesPrinter;
        IShapeTransformer shapeTransformer;
        IEnumerable<INameWithNamedAttributes> shapesAttributes;
        IEnumerable<INameWithNamedAttributes> transformsAttributes;

        public ShapesAndTransformations(INameWithNamedAttributesGetter shapesAttributesGetter
            , IShapeVerticesGetter shapesVerticesGetter
            , INameWithNamedAttributesGetter transformationsAttributesGetter
            , INameWithNamedAttributesConsolePrinter NameWithNamedAttributesPrinter
            , IShapeTransformer shapeTransformer)
        {
            // TODO: These cannot be null
            this.shapesAttributesGetter = shapesAttributesGetter;
            this.shapesVerticesGetter = shapesVerticesGetter;
            this.transformationsAttributesGetter = transformationsAttributesGetter;
            this.shapeAttributesPrinter = NameWithNamedAttributesPrinter;
            this.shapeTransformer = shapeTransformer;
        }

        public void LoadShapes()
        {
            Console.WriteLine("Loading shapes");
            shapesAttributes = shapesAttributesGetter.Get();
        }

        public void LoadTransforms()
        {
            Console.WriteLine("Loading transforms");
            transformsAttributes = transformationsAttributesGetter.Get();
        }

        public void PrintShapes()
        {
            Console.WriteLine("Printing shapes");
            shapeAttributesPrinter.Print(shapesAttributes);
        }

        public void TransformShapes()
        {
            Console.WriteLine("Transforming shapes");
            var shapeVertices = shapesVerticesGetter.Get();
            shapeTransformer.Transform();
        }
    }
}