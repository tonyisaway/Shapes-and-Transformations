using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IShapeCommand
    {
        void Execute(IEnumerable<IShapeVertex> vertices);
    }
}
