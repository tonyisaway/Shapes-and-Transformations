namespace Core.Interfaces
{
    using System.Collections.Generic;
    
    public interface IShapeCommand
    {
        void Execute(IEnumerable<IShapeVertex> vertices);
    }
}
