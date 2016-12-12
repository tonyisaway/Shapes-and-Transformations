namespace Domain.Models
{
    using System;
    using Interfaces;

    public class ShapeCommandGetter : IShapeCommandGetter
    {
        public IShapeCommand Get(INameWithNamedAttributes transformAttr)
        {
            var shapeCommand = new ShapeCommand();
            return shapeCommand;
        }
    }
}
