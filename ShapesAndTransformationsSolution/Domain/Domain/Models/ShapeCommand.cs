namespace Domain.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class ShapeCommand : IShapeCommand
    {
        public void Execute(IEnumerable<IShapeVertex> transformed)
        {
            return;
        }
    }
}
