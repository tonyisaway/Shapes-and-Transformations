namespace Domain.Models
{
    using System;
    using Contracts;
    using Interfaces;
    using System.Collections.Generic;

    public class ShapesAndTransformations : IShapesAndTransformations
    {
        INameWithNamedAttributesGetter shapesAttributesGetter;
        INameWithNamedAttributesGetter transformationsAttributesGetter;
        INameWithNamedAttributesConsolePrinter attributesPrinter;
        IShapeTransforGetter shapeTransformer;

        IEnumerable<INameWithNamedAttributes> shapesAttributes;
        IEnumerable<INameWithNamedAttributes> transformsAttributes;

        public ShapesAndTransformations(NameWithNamedAttributesGetter shapesAttributesGetter
            , NameWithNamedAttributesGetter transformationsAttributesGetter
            , NameWithNamedAttributesConsolePrinter attributesPrinter
            , ShapeTransformGetter shapeTransformer)
        {
            this.shapesAttributesGetter = shapesAttributesGetter;
            this.transformationsAttributesGetter = transformationsAttributesGetter;
            this.attributesPrinter = attributesPrinter;
            this.shapeTransformer = shapeTransformer;

            LoadShapes();
            LoadTransforms();
        }

        void LoadShapes()
        {
            Console.WriteLine("Loading shapes");
            shapesAttributes = shapesAttributesGetter.Get();
        }

        void LoadTransforms()
        {
            Console.WriteLine("Loading transforms");
            transformsAttributes = transformationsAttributesGetter.Get();
        }

        public void PrintShapes()
        {
            Console.WriteLine("Printing shapes");
            attributesPrinter.Print(shapesAttributes);
        }

        public void TransformShapes()
        {
            Console.WriteLine("Transforming shapes");
            foreach (var shapesAttribute in shapesAttributes)
            {
                shapeTransformer.TransformGet(shapesAttribute, transformsAttributes);
            }
        }
    }
}