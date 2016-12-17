namespace Core.Services
{
    using Interfaces;
    using System;
    using System.Collections.Generic;

    public class ShapesAndTransformations : IShapesAndTransformations
    {
        INameWithNamedAttributesGetter shapesAttributesGetter;
        IShapeVerticesGetter shapeVerticesGetter;
        INameWithNamedAttributesGetter transformationsAttributesGetter;
        INameWithNamedAttributesConsolePrinter attributesPrinter;
        IShapeCommandsGetter shapeCommandsGetter;

        IEnumerable<INameWithNamedAttributes> shapesAttributes;
        IEnumerable<INameWithNamedAttributes> transformsAttributes;

        public ShapesAndTransformations(INameWithNamedAttributesGetter shapesAttributesGetter
            , IShapeVerticesGetter shapeVerticesGetter
            , INameWithNamedAttributesGetter transformationsAttributesGetter
            , INameWithNamedAttributesConsolePrinter attributesPrinter
            , IShapeCommandsGetter shapeCommandsGetter)
        {
            this.shapesAttributesGetter = shapesAttributesGetter;
            this.shapeVerticesGetter = shapeVerticesGetter;
            this.transformationsAttributesGetter = transformationsAttributesGetter;
            this.attributesPrinter = attributesPrinter;
            this.shapeCommandsGetter = shapeCommandsGetter;

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

            var commands = shapeCommandsGetter.Get(transformsAttributes);

            foreach(var shapeAttributes in shapesAttributes)
            {
                foreach(var command in commands)
                {
                    var vertices = shapeVerticesGetter.Get(shapeAttributes);
                    command.Execute(vertices);
                }
            }
        }
    }
}