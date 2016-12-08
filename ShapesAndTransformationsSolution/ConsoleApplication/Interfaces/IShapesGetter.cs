namespace ConsoleApplication.Interfaces
{
    using System.Collections.Generic;

    public interface IShapesGetter
    {
        IEnumerable<IShape> GetAll(IEnumerable<IShapeParameters> shapeParameters);
    }
}