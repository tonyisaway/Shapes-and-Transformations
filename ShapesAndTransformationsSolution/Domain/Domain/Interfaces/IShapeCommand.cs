using System.Collections.Generic;

namespace Domain.Interfaces
{
    using System.Collections.Generic;

    public interface IShapeCommand
    {
        void Execute(IEnumerable<IShapeVertex> vertices);
    }
}
