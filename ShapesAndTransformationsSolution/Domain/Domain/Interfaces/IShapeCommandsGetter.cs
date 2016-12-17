namespace Core.Interfaces
{
    using System.Collections.Generic;

    public interface IShapeCommandsGetter
    {
        IEnumerable<IShapeCommand> Get(IEnumerable<INameWithNamedAttributes> instructions);
    }
}
