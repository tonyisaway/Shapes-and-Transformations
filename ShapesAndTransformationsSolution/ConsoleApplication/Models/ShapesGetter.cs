namespace ConsoleApplication.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class ShapesGetter : IShapesGetter
    {
        IShapeFactory factory;

        public ShapesGetter(IShapeFactory factory)
        {
            this.factory = factory;
        }

        public IEnumerable<IShape> GetAll(IEnumerable<IShapeParameters> shapeParameters)
        {
            var shapes = new List<IShape>();
            foreach(var param in shapeParameters)
            {
                var shape = factory.Create(param);
                shapes.Add(shape);
            }

            return shapes;
        }
    }
}
