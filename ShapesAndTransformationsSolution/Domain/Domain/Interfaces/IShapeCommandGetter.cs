namespace Core.Interfaces
{
    public interface IShapeCommandGetter
    {
        IShapeCommand Get(INameWithNamedAttributes instructions);
    }
}

