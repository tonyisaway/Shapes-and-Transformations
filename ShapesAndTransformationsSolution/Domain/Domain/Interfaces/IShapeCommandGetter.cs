namespace Domain.Interfaces
{
    public interface IShapeCommandGetter
    {
        IShapeCommand Get(INameWithNamedAttributes instructions);
    }
}